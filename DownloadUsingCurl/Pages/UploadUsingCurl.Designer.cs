namespace DownloadUsingCurl.Pages
{
    partial class UploadUsingCurl
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
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.BtnSelectUploadFile = new System.Windows.Forms.Button();
            this.lblSelectUploadFile = new System.Windows.Forms.Label();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateMCJson = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.BtnProcessData = new System.Windows.Forms.Button();
            this.btnViewLastExecutionError = new System.Windows.Forms.Button();
            this.btnViewExecOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(68, 69);
            this.txtSelectedFile.Multiline = true;
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.ReadOnly = true;
            this.txtSelectedFile.Size = new System.Drawing.Size(648, 47);
            this.txtSelectedFile.TabIndex = 0;
            // 
            // BtnSelectUploadFile
            // 
            this.BtnSelectUploadFile.Location = new System.Drawing.Point(722, 69);
            this.BtnSelectUploadFile.Name = "BtnSelectUploadFile";
            this.BtnSelectUploadFile.Size = new System.Drawing.Size(75, 47);
            this.BtnSelectUploadFile.TabIndex = 1;
            this.BtnSelectUploadFile.Text = "Select";
            this.BtnSelectUploadFile.UseVisualStyleBackColor = true;
            this.BtnSelectUploadFile.Click += new System.EventHandler(this.BtnSelectUploadFile_Click);
            // 
            // lblSelectUploadFile
            // 
            this.lblSelectUploadFile.AutoSize = true;
            this.lblSelectUploadFile.Location = new System.Drawing.Point(64, 36);
            this.lblSelectUploadFile.Name = "lblSelectUploadFile";
            this.lblSelectUploadFile.Size = new System.Drawing.Size(513, 20);
            this.lblSelectUploadFile.TabIndex = 2;
            this.lblSelectUploadFile.Text = "Please select the file that will be uploaded to AWS S3 Bucket using Curl";
            this.lblSelectUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdUploadFile
            // 
            this.ofdUploadFile.FileName = "ofdUploadFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste Create Media Content JSON object result here to obtain Presigned URL for Up" +
    "load";
            // 
            // txtCreateMCJson
            // 
            this.txtCreateMCJson.Location = new System.Drawing.Point(72, 176);
            this.txtCreateMCJson.Multiline = true;
            this.txtCreateMCJson.Name = "txtCreateMCJson";
            this.txtCreateMCJson.Size = new System.Drawing.Size(644, 277);
            this.txtCreateMCJson.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(668, 490);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(129, 51);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // BtnProcessData
            // 
            this.BtnProcessData.Location = new System.Drawing.Point(722, 400);
            this.BtnProcessData.Name = "BtnProcessData";
            this.BtnProcessData.Size = new System.Drawing.Size(75, 53);
            this.BtnProcessData.TabIndex = 6;
            this.BtnProcessData.Text = "Parse";
            this.BtnProcessData.UseVisualStyleBackColor = true;
            this.BtnProcessData.Click += new System.EventHandler(this.BtnProcessData_Click);
            // 
            // btnViewLastExecutionError
            // 
            this.btnViewLastExecutionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewLastExecutionError.Location = new System.Drawing.Point(363, 490);
            this.btnViewLastExecutionError.Name = "btnViewLastExecutionError";
            this.btnViewLastExecutionError.Size = new System.Drawing.Size(240, 51);
            this.btnViewLastExecutionError.TabIndex = 7;
            this.btnViewLastExecutionError.Text = "View Last Execution Error";
            this.btnViewLastExecutionError.UseVisualStyleBackColor = true;
            this.btnViewLastExecutionError.Click += new System.EventHandler(this.btnViewLastExecutionError_Click);
            // 
            // btnViewExecOutput
            // 
            this.btnViewExecOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnViewExecOutput.Location = new System.Drawing.Point(72, 490);
            this.btnViewExecOutput.Name = "btnViewExecOutput";
            this.btnViewExecOutput.Size = new System.Drawing.Size(260, 51);
            this.btnViewExecOutput.TabIndex = 8;
            this.btnViewExecOutput.Text = "View Last Execution Output";
            this.btnViewExecOutput.UseVisualStyleBackColor = true;
            this.btnViewExecOutput.Click += new System.EventHandler(this.btnViewExecOutput_Click);
            // 
            // UploadUsingCurl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 583);
            this.Controls.Add(this.btnViewExecOutput);
            this.Controls.Add(this.btnViewLastExecutionError);
            this.Controls.Add(this.BtnProcessData);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtCreateMCJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectUploadFile);
            this.Controls.Add(this.BtnSelectUploadFile);
            this.Controls.Add(this.txtSelectedFile);
            this.Name = "UploadUsingCurl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload File To AWS S3 Using Curl (From Powershell)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Button BtnSelectUploadFile;
        private System.Windows.Forms.Label lblSelectUploadFile;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateMCJson;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button BtnProcessData;
        private System.Windows.Forms.Button btnViewLastExecutionError;
        private System.Windows.Forms.Button btnViewExecOutput;
    }
}