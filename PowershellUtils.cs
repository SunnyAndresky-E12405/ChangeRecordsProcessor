using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChangeRecordsProcessor
{
    public class PowershellUtils
    {

        public static void RunScriptAsynchronously(string scriptFile, string previousFile, string newFile, string outputFile)
        {

            using (var ps = PowerShell.Create())
            {
                ps.AddCommand(scriptFile)
                    .AddParameter("newFile", newFile)
                    .AddParameter("previousFile", previousFile)
                    .AddParameter("outputFile", outputFile);

                //ps.Invoke();

                // begin invoke execution on the Powershell
                IAsyncResult result = ps.BeginInvoke();
                // do something else until execution has completed.
                // this could be sleep/wait, or perhaps some other work
                while (result.IsCompleted == false)
                {
                    Console.WriteLine("Waiting for pipeline to finish...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Finished!");
            }
        }
    }
}
