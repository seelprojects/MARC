using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_User_Review_Sniffer
{
    public partial class Form1 : Form
    {
        string appID;
        List<string> userReviews = new List<string>();

        public Form1()
        {
            InitializeComponent();
            numPages.Text = "1";
        }
        //Gmail = 422689480;
        //Facebook = 284882215;
        //Chrome = 535886823;
        //Netflix = 363590051;
        //Spotify = 324684580;
        //Uber = 368677368;
        //Geico = 331763096;
        //Google Maps = 585027354;
        //FitBit = 462638897;
        //Credit Karma = 519817714;
        //Progressive = 349731802;
        private async void importComments_Click(object sender, EventArgs e)
        {
            appID = appleIDLabel.Text;
            Loading loadingWindow = new Loading();
            loadingWindow.Show();
            try
            {

                int numPage = int.Parse(numPages.Text);
                userReviews.Clear();
                for (int i = 1; i <= numPage; i++)
                {
                    userReviews.AddRange(await WebCall(appID, i));
                    // makeServerCall();
                }
            }
            catch (Exception ex)
            {
             
            }
            loadingWindow.Close();
            reviewListBox.DataSource = null;
            reviewListBox.Update();
            reviewListBox.DataSource = userReviews;
            reviewListBox.Update();
        }
        private Task<List<string>> WebCall(string id, int page)
        {
            return Task.Run(() =>
            {
                return makeServerCall(id, page);
            });
        }
        private List<string> makeServerCall(string appID, int page)
        {
            //userReviews.Clear();
            List<string> allReviews = new List<string>();

            try
            {
                //string urlold = "https://itunes.apple.com/rss/customerreviews/id=" + appID + "/json";
                string url = "https://itunes.apple.com/rss/customerreviews/page=" + page + "/id=" + appID + "/sortby=mostrecent/json";
                var request = WebRequest.Create(url);
                request.ContentType = "application/json; charset=utf-8";
                string text;
                var response = (HttpWebResponse)request.GetResponse();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    text = sr.ReadToEnd();
                }
                JObject jsonObject = JObject.Parse(text);
                RootObject deserializedObject = JsonConvert.DeserializeObject<RootObject>(jsonObject.ToString());
                foreach (var entry in deserializedObject.feed.entry)
                {
                    if (entry != null)
                    {
                        try
                        {
                            //userReviews.Add();
                            allReviews.Add(entry.content.label);
                        }
                        catch (Exception exq)
                        {
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                //error
                return null;
            }
            return allReviews;
        }

        private void exportComments_Click(object sender, EventArgs e)
        {
            StreamWriter reviewWriter = new StreamWriter(Application.StartupPath + "\\reviews.txt");
            foreach (string review in userReviews)
            {
                reviewWriter.WriteLine(review);
            }
            reviewWriter.Close();
            if (userReviews.Count != 0)
            {
                MessageBox.Show("Successfully Exported!");
            }
            else
            {
                MessageBox.Show("Nothing to Export!");
            }
        }
    }
}
