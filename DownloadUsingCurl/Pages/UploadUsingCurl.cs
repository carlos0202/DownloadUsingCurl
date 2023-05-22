using DownloadUsingCurl.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadUsingCurl.Pages
{
    public partial class UploadUsingCurl : Form
    {
        private string SelectedFilePath;
        private string PresignedURL;
        private string LastExecutionError;
        private string LastExecutionOutput;
        private HttpClient _client;

        public UploadUsingCurl()
        {
            InitializeComponent();

            this._client = new HttpClient();
        }

        private void BtnSelectUploadFile_Click(object sender, EventArgs e)
        {
            this.ofdUploadFile.Filter = "All Files (*.*)|*.*";
            this.ofdUploadFile.FilterIndex = 1;
            this.ofdUploadFile.Multiselect = false;

            if (this.ofdUploadFile.ShowDialog() == DialogResult.OK)
            {
                string sFileName = this.ofdUploadFile.FileName;
                this.txtSelectedFile.Text = sFileName;
                this.SelectedFilePath = sFileName;
            }
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            //var command = $"curl.exe --upload-file {SelectedFilePath} \"{PresignedURL}\"";
            //ProcessStartInfo startInfo = new ProcessStartInfo
            //{
            //    FileName = @"C:\windows\system32\windowspowershell\v1.0\powershell.exe",
            //    Arguments = $"-Command \"{ command }\"",
            //    RedirectStandardOutput = true,
            //    RedirectStandardError = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = false
            //};
            //Process process = new Process
            //{
            //    StartInfo = startInfo
            //};
            //process.Start();

            //this.LastExecutionOutput = process.StandardOutput.ReadToEnd();
            //this.LastExecutionError = process.StandardError.ReadToEnd();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, this.PresignedURL);
            request.Content = new ByteArrayContent(File.ReadAllBytes(this.SelectedFilePath));

            HttpResponseMessage response = await this._client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            this.LastExecutionOutput = responseBody;
        }

        private void BtnProcessData_Click(object sender, EventArgs e)
        {
            var inputData = this.txtCreateMCJson.Text;

            var jsonData = JsonConvert.DeserializeObject<CreateMediaContentResult>(inputData);
            if(jsonData != null && jsonData.PresignedUploadUrl != null)
            {
                this.PresignedURL = jsonData.PresignedUploadUrl;
                this.btnUpload.Enabled = true;
            }
        }

        private void btnViewExecOutput_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.LastExecutionOutput);
        }

        private void btnViewLastExecutionError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.LastExecutionError);
        }
    }
}
