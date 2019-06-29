using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberSitesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTür.Items.Add("gundem");
            cmbTür.Items.Add("spor");
            cmbTür.Items.Add("egitim");
            cmbTür.Items.Add("ekonomi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostData();
        }

        private String getData(String url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            
            return html;
        }

        private void PostData()
        {
            String title = txthaberBasligi.Text;
            String body = txthaberIcerik.Text;
            String type = cmbTür.Text;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://crazynews-yagmur.herokuapp.com/news");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"pathOfImage\":\"" + title + "\"," +
                              "\"title\":\"" + title + "\"," +
                              "\"body\":\"" + body + "\"," +
                                "\"type\":\"" + type + "\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        private void btn_listele_click(object sender, EventArgs e)
        {
            String Data = getData("https://crazynews-yagmur.herokuapp.com/news");
            List <News> liste = JsonConvert.DeserializeObject<List<News>>(Data);
            dataGridView1.DataSource = liste;
            
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                newPictures.Image = Image.FromFile(dosya.FileName);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                News new1 = new News();
                string JSONresult = JsonConvert.SerializeObject(new1);
                String id = drow.Cells[6].Value.ToString();
                string path = "https://crazynews-yagmur.herokuapp.com/news/" + id;

                WebRequest request = WebRequest.Create(path);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
