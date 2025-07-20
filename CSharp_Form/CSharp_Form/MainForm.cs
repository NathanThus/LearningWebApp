using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Form
{
    public partial class MainForm : Form
    {
        private const bool ClosedConnection = false;
        private HttpClient _httpClient;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (_httpClient != null)
            {
                MessageBox.Show("You are already connected!", "Failure to setup connection",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(tB_URL.Text + tB_Database.Text)
            };

            _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage msg = _httpClient.GetAsync("").Result;
            UpdateConnectionStateTextBox(msg.IsSuccessStatusCode);
        }

        private void UpdateConnectionStateTextBox(bool connectionState)
        {
            if (connectionState)
            {
                tB_ConnectionState.BackColor = Color.Green;
                tB_ConnectionState.Text = "CONNECTED";
            }
            else
            {
                tB_ConnectionState.BackColor = Color.Red;
                tB_ConnectionState.Text = "NOT CONNECTED";
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            _httpClient.Dispose();
            UpdateConnectionStateTextBox(ClosedConnection);
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            if(_httpClient == null)
            {
                MessageBox.Show("You are not connected!", "Failure to setup request",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HttpResponseMessage msg = _httpClient.GetAsync("").Result;
            string[] data = msg.Content.ReadAsStringAsync().Result.Split('\n');
            lB_Results.Items.Clear();
            foreach (string str in data)
            {
                lB_Results.Items.Add(str);
            }
        }

        ~MainForm()
        {
            if (_httpClient != null)
                _httpClient.Dispose();
        }
    }
}
