
namespace ChangeRecordsProcessor
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreviousFile = new System.Windows.Forms.TextBox();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowsePreviousFile = new System.Windows.Forms.Button();
            this.btnBrowseNewFile = new System.Windows.Forms.Button();
            this.btnBrowseOutputFile = new System.Windows.Forms.Button();
            this.lblWorkingFolder = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWorkingFolderLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous File: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New File: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output File: ";
            // 
            // txtPreviousFile
            // 
            this.txtPreviousFile.Location = new System.Drawing.Point(299, 50);
            this.txtPreviousFile.Name = "txtPreviousFile";
            this.txtPreviousFile.Size = new System.Drawing.Size(521, 20);
            this.txtPreviousFile.TabIndex = 3;
            // 
            // txtNewFile
            // 
            this.txtNewFile.Location = new System.Drawing.Point(299, 104);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(521, 20);
            this.txtNewFile.TabIndex = 4;
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(299, 163);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(521, 20);
            this.txtOutputFile.TabIndex = 5;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProcess.Location = new System.Drawing.Point(480, 280);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(91, 29);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowsePreviousFile
            // 
            this.btnBrowsePreviousFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowsePreviousFile.Location = new System.Drawing.Point(828, 41);
            this.btnBrowsePreviousFile.Name = "btnBrowsePreviousFile";
            this.btnBrowsePreviousFile.Size = new System.Drawing.Size(68, 29);
            this.btnBrowsePreviousFile.TabIndex = 7;
            this.btnBrowsePreviousFile.Text = "Browse";
            this.btnBrowsePreviousFile.UseVisualStyleBackColor = true;
            this.btnBrowsePreviousFile.Click += new System.EventHandler(this.btnBrowsePreviousFile_Click);
            // 
            // btnBrowseNewFile
            // 
            this.btnBrowseNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowseNewFile.Location = new System.Drawing.Point(827, 96);
            this.btnBrowseNewFile.Name = "btnBrowseNewFile";
            this.btnBrowseNewFile.Size = new System.Drawing.Size(69, 28);
            this.btnBrowseNewFile.TabIndex = 8;
            this.btnBrowseNewFile.Text = "Browse";
            this.btnBrowseNewFile.UseVisualStyleBackColor = true;
            this.btnBrowseNewFile.Click += new System.EventHandler(this.btnBrowseNewFile_Click);
            // 
            // btnBrowseOutputFile
            // 
            this.btnBrowseOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowseOutputFile.Location = new System.Drawing.Point(828, 158);
            this.btnBrowseOutputFile.Name = "btnBrowseOutputFile";
            this.btnBrowseOutputFile.Size = new System.Drawing.Size(68, 28);
            this.btnBrowseOutputFile.TabIndex = 9;
            this.btnBrowseOutputFile.Text = "Browse";
            this.btnBrowseOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFile.Click += new System.EventHandler(this.btnBrowseOutputFile_Click);
            // 
            // lblWorkingFolder
            // 
            this.lblWorkingFolder.AutoSize = true;
            this.lblWorkingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingFolder.Location = new System.Drawing.Point(157, 231);
            this.lblWorkingFolder.Name = "lblWorkingFolder";
            this.lblWorkingFolder.Size = new System.Drawing.Size(106, 16);
            this.lblWorkingFolder.TabIndex = 11;
            this.lblWorkingFolder.Text = "Working Folder: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(487, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(-14, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 374);
            this.panel1.TabIndex = 15;
            // 
            // lblWorkingFolderLocation
            // 
            this.lblWorkingFolderLocation.AutoSize = true;
            this.lblWorkingFolderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingFolderLocation.Location = new System.Drawing.Point(296, 231);
            this.lblWorkingFolderLocation.Name = "lblWorkingFolderLocation";
            this.lblWorkingFolderLocation.Size = new System.Drawing.Size(80, 16);
            this.lblWorkingFolderLocation.TabIndex = 16;
            this.lblWorkingFolderLocation.Text = "C:\\TestFiles";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 371);
            this.Controls.Add(this.lblWorkingFolderLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWorkingFolder);
            this.Controls.Add(this.btnBrowseOutputFile);
            this.Controls.Add(this.btnBrowseNewFile);
            this.Controls.Add(this.btnBrowsePreviousFile);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.txtPreviousFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMain";
            this.Text = "Process Full File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreviousFile;
        private System.Windows.Forms.TextBox txtNewFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBrowsePreviousFile;
        private System.Windows.Forms.Button btnBrowseNewFile;
        private System.Windows.Forms.Button btnBrowseOutputFile;
        private System.Windows.Forms.Label lblWorkingFolder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWorkingFolderLocation;
    }
}

