param (
	$previousFile = "C:\TestFiles\RegressionSuiteDNTouch_9899_AGC0002752661_15062022100001.csv",
	$newFile = "C:\TestFiles\RegressionSuiteDNTouch_9899_AGC0002752661_22062022100001.csv",
	$outputFile = "C:\TestFiles\NewFile.csv"
)

$StartTime = $(get-date)


#Temp files for Processing
$outputPreviousFile = "C:\TestFiles\OutPreviousFile.csv"
$outputNewFile = "C:\TestFiles\OutNewFile.csv"
$diffFile = "C:\TestFiles\differenceFile.csv"
$extracttxt = "C:\TestFiles\change.txt"
$extractAlltxt = "C:\TestFiles\extractAllID.txt"
$duplicatetxt = "C:\TestFiles\duplicate.txt"
$headers = 1..100
$idHeaders = 1..5

#Handle trailing commas in new file

Import-Csv $previousFile -Header $headers |ConvertTo-Csv -NoTypeInformation  | Select-Object -Skip 1   | % {$_ -replace '"',''}| Set-Content -path $outputPreviousFile

Import-Csv $newFile -Header $headers |ConvertTo-Csv -NoTypeInformation  | Select-Object -Skip 1   | % {$_ -replace '"',''}| Set-Content -path $outputNewFile


#Compare contents of both file and write the difference records
Compare-Object -ReferenceObject (Get-Content -Path $outputPreviousFile) -DifferenceObject (Get-Content -Path $outputNewFile) | Where-Object { $_.SideIndicator -eq "=>" }| Select InputObject |ConvertTo-Csv -NoTypeInformation  | Select-Object -Skip 1   | % {$_ -replace '"',''}| Set-Content -path $diffFile


#Extract Employee IDs
$modifiedData = Import-Csv $diffFile -Header $idHeaders
$ids=@()

foreach ($row in $modifiedData)
{
	#Write-Output $row.1
	If($row.1 -eq 'SPSE'  -Or $row.1 -eq 'DPDT'  ){
		$data = $row.3		
	 }
	 else
	 {
		$data = $row.4		
	 }
	 If (-not ($ids.Contains($data))){
		$ids += $data
	 }
}
 $ids = $ids | sort -unique | Out-File  $extracttxt

#Find the records form New file with the employee id and generate the output file
$keys=get-content $extracttxt
Import-Csv  $newFile -Header $headers  | Where {$keys -contains $_.3 -or $keys -contains $_.4} | ConvertTo-Csv  -NoType | % {$_ -replace '"',''}| Select-Object -Skip 1 | Set-Content $outputFile 

#Creating duplicate file
$previousData = Import-Csv $previousFile -Header $idHeaders
$ids=@()

foreach ($row in $previousData)
{
	#Write-Output $row.1
	If($row.1 -eq 'SPSE'  -Or $row.1 -eq 'DPDT'  ){		
		$data = $row.3
	}
	else {
		$data = $row.4		
	 }
	 #Write-Host($data)
	 If (-not ($ids.Contains($data))){
		$ids += $data
	 }
}
 $ids = $ids | Out-File  $extractAlltxt
 
 Compare-Object -ReferenceObject (Get-Content -Path $extractAlltxt) -DifferenceObject (Get-Content -Path $extracttxt) -PassThru  | Where-Object { $_.SideIndicator -eq "<=" }|   format-list | Out-File $duplicatetxt
 
 
#Get Elapsed time
$elapsedTime = $(get-date) - $StartTime

$totalTime = "{0:HH:mm:ss}" -f ([datetime]$elapsedTime.Ticks)
Write-Host 'Append Comma approach takes: '+ $totalTime