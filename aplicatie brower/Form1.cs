using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;

namespace aplicatie_brower
{
    public partial class Form1 : Form
    {
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private async void InitializeBrowser()
        {
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;

            // Add WebView2 to the correct tab page (tab 1 = Browser)
            tabPage1.Controls.Add(webView);
            webView.BringToFront();

            await webView.EnsureCoreWebView2Async(null);
            webView.Source = new Uri("https://google.com");

            // Update URL bar when page changes
            webView.NavigationCompleted += (s, e) =>
            {
                textBox1.Text = webView.Source.ToString();
                this.Text = webView.CoreWebView2.DocumentTitle;
            };
        }

        private void GoToUrl(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "https://" + url;

            webView.Source = new Uri(url);
        }

        // GO button
        private void button1_Click(object sender, EventArgs e)
        {
            GoToUrl(textBox1.Text);
        }

        // Press Enter in URL bar
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GoToUrl(textBox1.Text);
        }

        // Forward button
        private void button3_Click(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
                webView.GoForward();
        }

        // Back button
        private void button2_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
                webView.GoBack();
        }

        // Home button
        private void button4_Click(object sender, EventArgs e)
        {
            webView.Source = new Uri("https://www.google.com");
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OraCurenta = DateTime.Now;
            label1.Text = OraCurenta.ToLongTimeString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "Browser";
            tabControl1.TabPages[1].Text = "Timer";
            tabControl1.TabPages[2].Text = "Progres Bar";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) { }
    }
}