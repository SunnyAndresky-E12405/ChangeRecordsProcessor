using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeRecordsProcessor
{
    public partial class FrmMain : Form
    {
        private static String scriptFile = "StripChangeRecords.ps1";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            btnProcess.Enabled = false;
            btnBrowseNewFile.Enabled = false;
            btnBrowsePreviousFile.Enabled = false;
            btnBrowseOutputFile.Enabled = false;
            String scriptPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, scriptFile);
            String previousFile = txtPreviousFile.Text;
            String newFile = txtNewFile.Text;
            String outputFile = txtOutputFile.Text;
            RunScriptAsynchronously(scriptPath, previousFile, newFile, outputFile);
        }


        private void btnBrowsePreviousFile_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty; 
            OpenFileDialog ofdPreviousFile = new OpenFileDialog
            {
                Filter = "csv files (*.csv)|*.csv",
                InitialDirectory = "C:\\",
                RestoreDirectory = true,
                Title = "Browse the Previous Legacy CSV File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",

                FilterIndex = 2,


            };

            if (ofdPreviousFile.ShowDialog() == DialogResult.OK)
            {
                txtPreviousFile.Text = ofdPreviousFile.FileName;
            }
        }

        private void btnBrowseNewFile_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty; 
            OpenFileDialog ofdNewFile = new OpenFileDialog
            {
                Filter = "csv files (*.csv)|*.csv",
                InitialDirectory = "C:\\",
                RestoreDirectory = true,
                Title = "Browse the New Legacy CSV File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",

                FilterIndex = 2,


            };

            if (ofdNewFile.ShowDialog() == DialogResult.OK)
            {
                txtNewFile.Text = ofdNewFile.FileName;
            }
        }

        private void btnBrowseOutputFile_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            OpenFileDialog ofdOutputFile = new OpenFileDialog
            {
                Filter = "csv files (*.csv)|*.csv",
                InitialDirectory = "C:\\",
                RestoreDirectory = true,
                Title = "Browse the Output File",

                CheckFileExists = false,
                CheckPathExists = true,

                DefaultExt = "csv",

                FilterIndex = 2,


            };

            if (ofdOutputFile.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = ofdOutputFile.FileName;
            }
        }

        public void RunScriptAsynchronously(string scriptFile, string previousFile, string newFile, string outputFile)
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddCommand(scriptFile)
                    .AddParameter("newFile", newFile)
                    .AddParameter("previousFile", previousFile)
                    .AddParameter("outputFile", outputFile);

                // begin invoke execution on the Powershell
                IAsyncResult result = ps.BeginInvoke();


                while (result.IsCompleted == false)
                {
                    //Console.WriteLine("Waiting for pipeline to finish...");
                    Thread.Sleep(1000);
                }
                //Console.WriteLine("Finished!");
                lblStatus.Text = "Complete!";
                btnProcess.Enabled = true;
                btnBrowseNewFile.Enabled = true;
                btnBrowsePreviousFile.Enabled = true;
                btnBrowseOutputFile.Enabled = true;

            }
        }
    }
}
