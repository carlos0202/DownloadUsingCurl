namespace DownloadUsingCurl
{
    partial class MainScr
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
            this.btnOpenUploadUsingCurlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenUploadUsingCurlBtn
            // 
            this.btnOpenUploadUsingCurlBtn.Location = new System.Drawing.Point(12, 12);
            this.btnOpenUploadUsingCurlBtn.Name = "btnOpenUploadUsingCurlBtn";
            this.btnOpenUploadUsingCurlBtn.Size = new System.Drawing.Size(195, 37);
            this.btnOpenUploadUsingCurlBtn.TabIndex = 0;
            this.btnOpenUploadUsingCurlBtn.Text = "Upload Using HttpClient";
            this.btnOpenUploadUsingCurlBtn.UseVisualStyleBackColor = true;
            this.btnOpenUploadUsingCurlBtn.Click += new System.EventHandler(this.btnOpenUploadUsingCurlBtn_Click);
            // 
            // MainScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 146);
            this.Controls.Add(this.btnOpenUploadUsingCurlBtn);
            this.Name = "MainScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ze Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenUploadUsingCurlBtn;
    }
}

