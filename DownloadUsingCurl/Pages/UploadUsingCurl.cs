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
        private string LastExecutionOutput;
        private HttpClient _client;

        public UploadUsingCurl()
        {
            InitializeComponent();

            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            this._client = new HttpClient(handler);
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
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, this.PresignedURL);
            request.Content = new ByteArrayContent(File.ReadAllBytes(this.SelectedFilePath));


            HttpResponseMessage response = await this._client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            this.LastExecutionOutput = NormalizePutOutput(responseBody);
            CleanAfterExecution();
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

        private void CleanAfterExecution()
        {
            this.btnUpload.Enabled = false;
            this.PresignedURL = null;
            this.SelectedFilePath = null;
            this.txtSelectedFile.Text = null;
            this.txtCreateMCJson.Text = null;
        }

        private string NormalizePutOutput(string output)
        {
            if(string.IsNullOrWhiteSpace(output)) 
            {
                return "Everything is good. You're killing it!!!";
            }

            return $"Execution output: {output}";
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            this.txtCreateMCJson.Text = Clipboard.GetText();
        }

        private void btnClearInputData_Click(object sender, EventArgs e)
        {
            CleanAfterExecution();
        }
    }
}
