using DownloadUsingCurl.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadUsingCurl
{
    public partial class MainScr : Form
    {
        private readonly Button uploadUsingCurlBtn;
        private UploadUsingCurl _uploadUsingCurlFrm;

        public MainScr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(uploadUsingCurlBtn);
        }

        private void btnOpenUploadUsingCurlBtn_Click(object sender, EventArgs e)
        {
            _uploadUsingCurlFrm = new UploadUsingCurl();
            _uploadUsingCurlFrm.ShowDialog(this);
        }
    }
}
