using LAIR.Collections.Generic;
using LAIR.ResourceAPIs.FrameNet;
using MetroFramework.Forms;
using Apple_User_Review_Sniffer;
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
using FrameNetOnline;
using WekaClassifier;
using PorterStemmer;
using StopWordRemoval;
using System.Diagnostics;

namespace Master_ARC_1
{
    public partial class AppIdClassification : Form
    {
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
        //Adobe 	= 469337564; 	
        //Chrome = 535886823;
        //CNN  	= 331786748;
        //eBay = 282614216;
        //IMDB = 342792525;

        ImageList imageList = new ImageList();
        List<string> userReviews = new List<string>();
        List<string> userReviewsSentenceSplit = new List<string>();
        List<string> singleUserReview = new List<string>();
        List<string> tempUserReviews = new List<string>();
        List<List<string>> listOfReviewsBoF;
        List<string> filteredReviews;
        int currentReviewIndex = 0;
        Loading load = new Loading();
        string appId;
        int numPage;
        string exceptionMessage;
        string classification = "Classification";
        List<string> allClassification = new List<string>();
        private ImageList imagelist;
        public AppIdClassification()
        {
            InitializeComponent();

            //var test = Application.StartupPath.ToString();

            //var directoryName = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
            var directoryName = Application.StartupPath;

            imagelist = new ImageList();
            imagelist.Images.Add(Image.FromFile(directoryName + "\\Images\\bug_n.png"));
            imagelist.Images.Add(Image.FromFile(directoryName + "\\Images\\request.png"));
            imagelist.Images.Add(Image.FromFile(directoryName + "\\Images\\ic_question.png"));
            imageList.ImageSize = new Size(50, 50);


            numberOfReviewsCombo.Items.Add(50); numberOfReviewsCombo.Items.Add(100); numberOfReviewsCombo.Items.Add(150); numberOfReviewsCombo.Items.Add(200); numberOfReviewsCombo.Items.Add(250);
            numberOfReviewsCombo.Items.Add(300); numberOfReviewsCombo.Items.Add(350); numberOfReviewsCombo.Items.Add(400); numberOfReviewsCombo.Items.Add(450); numberOfReviewsCombo.Items.Add(500);
            numberOfReviewsCombo.SelectedIndex = 0;

            boWordsClassification.Checked = true;
            defaultTraining.Checked = true;

            boWordsClassification.CheckedChanged += boWClassification_CheckedChanged;
            defaultTraining.CheckedChanged += DefaultTraining_CheckedChanged;
            boFramesClassification.CheckedChanged += boFramesClassification_CheckedChanged;
            customTraining.CheckedChanged += CustomTraining_CheckedChanged;

        }

        private void boWClassification_CheckedChanged(object sender, EventArgs e)
        {
            if (boWordsClassification.Checked && boFramesClassification.Checked)
            {
                boFramesClassification.Checked = false;
            }
            else
            {
                boFramesClassification.Checked = true;
            }
        }

        private void boFramesClassification_CheckedChanged(object sender, EventArgs e)
        {
            if (boFramesClassification.Checked && boWordsClassification.Checked)
            {
                boWordsClassification.Checked = false;
            }
            else
            {
                boWordsClassification.Checked = true;
            }
        }

        private void CustomTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultTraining.Checked && customTraining.Checked)
            {
                defaultTraining.Checked = false;
            }
            else
            {
                defaultTraining.Checked = true;
            }
        }

        private void DefaultTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultTraining.Checked && customTraining.Checked)
            {
                customTraining.Checked = false;
            }
            else
            {
                customTraining.Checked = true;
            }
        }

        private void importReviews_Click(object sender, EventArgs e)
        {

            load.Show();
            appId = appIdTextBox.Text;
            try
            {
                numPage = int.Parse(numberOfReviewsCombo.SelectedIndex.ToString());
                numPage++;
            }
            catch (Exception ex)
            {
                numPage = 1;
            }
            userReviews.Clear();


            var bw = new BackgroundWorker();
            bw.DoWork += (o, args) => RetrieveUserReviews(appId, numPage);
            bw.RunWorkerCompleted += (o, args) => RetrieveUserReviewsUpdateControl();
            bw.RunWorkerAsync();
        }

        private void RetrieveUserReviews(string appId, int numPage)
        {
            for (int i = 1; i <= numPage; i++)
            {
                try
                {
                    userReviews.AddRange(makeServerCall(appId, i));
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void RetrieveUserReviewsUpdateControl()
        {
            reviewListBox.DataSource = null;
            reviewListBox.Update();
            reviewListBox.DataSource = userReviews;
            reviewListBox.Update();
            load.Hide();
            numberOfReviews.Text = userReviews.Count() + "  Reviews Imported ";
        }

        private List<string> makeServerCall(string appID, int page)
        {
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
                Apple_User_Review_Sniffer.RootObject deserializedObject = JsonConvert.DeserializeObject<Apple_User_Review_Sniffer.RootObject>(jsonObject.ToString());
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

        private void classifyCurrentReview_Click(object sender, EventArgs e)
        {
            if (customTraining.Checked && !File.Exists(trainingFilePath.Text))
            {
                MessageBox.Show("Please select a valid training file.");
            }
            else
            {
                load.Show();
                var bwClassifyCurrent = new BackgroundWorker();
                bwClassifyCurrent.DoWork += (o, args) => classifyCurrentUserReview(singleUserReview, customTraining.Checked ? trainingFilePath.Text : null);
                bwClassifyCurrent.RunWorkerCompleted += (o, args) => classifyCurentUserReviewUpdateControl(singleUserReview);
                bwClassifyCurrent.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Classify User Reviews. Takes in user review list and training file path
        /// </summary>
        /// <param name="singleUserReviewSentences"></param>
        /// <param name="trainingFilePath"></param>
        private void classifyCurrentUserReview(List<string> singleUserReviewSentences, string trainingFilePath)
        {

            allClassification = new List<string>();
            WekaClassifier.WekaClassifier classifier;
            if (boFramesClassification.Checked)
            {
                //Server Test
                FrameNetOnline.FrameNetOnline frameNetServerTest = new FrameNetOnline.FrameNetOnline("This is a test.");

                //if server test passes (returns more than 0 frames) then proceed with frame extraction.
                if (frameNetServerTest.output.Count != 0)
                {
                    listOfReviewsBoF = new List<List<string>>();
                    currentReviewIndex = 0;
                    foreach (string review in singleUserReviewSentences)
                    {
                        currentReviewIndex++;
                        FrameNetOnline.FrameNetOnline abc = new FrameNetOnline.FrameNetOnline(review);
                        listOfReviewsBoF.Add(abc.output);
                        BeginInvoke(new MethodInvoker(updateLoadingSingleReviewFrames));
                    }

                    BeginInvoke(new MethodInvoker(updateLoadingTextClassifier));


                    try
                    {
                        classifier = new WekaClassifier.WekaClassifier(listOfReviewsBoF, trainingFilePath, Application.StartupPath);


                        foreach (string data in classifier.AllClassification)
                        {
                            allClassification.Add(data);
                        }

                    }
                    catch (Exception e)
                    {
                        exceptionMessage = e.ToString();
                        BeginInvoke(new MethodInvoker(exceptionMessageHandler));
                    }

                }
            }
            else if (boWordsClassification.Checked)
            {
                filteredReviews = new List<string>();
                foreach (string review in singleUserReviewSentences)
                {
                    filteredReviews.Add(FilterText(review));
                }


                BeginInvoke(new MethodInvoker(updateLoadingTextClassifier));
                try
                {
                    classifier = new WekaClassifier.WekaClassifier(filteredReviews, trainingFilePath, Application.StartupPath);

                    foreach (string data in classifier.AllClassification)
                    {
                        allClassification.Add(data);
                    }
                }
                catch (Exception e)
                {
                    exceptionMessage = e.ToString();
                    BeginInvoke(new MethodInvoker(exceptionMessageHandler));
                }
            }
        }

        /// <summary>
        /// Method to filter input text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string FilterText(string text)
        {
            text.Replace('.', ' ');
            if (removeStopwordsCheckbox.Checked)
            {
                StopWordRemoval.StopWordRemoval temp = new StopWordRemoval.StopWordRemoval(text, Application.StartupPath);
                text = temp.output;
            }
            if (stemmingCheckBox.Checked)
            {
                string[] words = text.Split(' ');
                string finalStemOutput = "";
                foreach (string word in words)
                {
                    Stemmer temp = new Stemmer();
                    temp.add(word.ToCharArray(), word.Length);
                    temp.stem();
                    var stemOutput = temp.ToString();
                    finalStemOutput += stemOutput + " ";
                }
                text = finalStemOutput;

            }
            text = RemoveSpecialCharacters(text);
            return text;
        }


        /// <summary>
        /// Remove special characters from input string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                // if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == ' ' || c == '-')
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')

                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        /// <summary>t
        /// Classify Current User Review and Update the control
        /// </summary>
        /// <param name="singleUserReviewSentences"></param>
        private void classifyCurentUserReviewUpdateControl(List<string> singleUserReviewSentences)
        {
            singleUserReviewListView.Clear();
            singleUserReviewListView.View = View.Details;
            singleUserReviewListView.SmallImageList = imagelist;
            singleUserReviewListView.Columns.Add("Classification Type", 110, HorizontalAlignment.Center);
            singleUserReviewListView.Columns.Add("Text", -2, HorizontalAlignment.Left);

            try
            {
                for (int i = 0; i < singleUserReviewSentences.Count; i++)
                {
                    int j = 0;
                    var item1 = new ListViewItem(new[] { allClassification.Count == 0 ? "Unknown" : (allClassification.ElementAt(i).ToString()), singleUserReviewSentences.ElementAt(i) });
                    item1.ImageIndex = allClassification.Count == 0 ? 2 : (allClassification.ElementAt(i).ToString() == "Bug Report" ? 0 : allClassification.ElementAt(i).ToString() == "Feature Request" ? 1 : 2);
                    singleUserReviewListView.Items.Add(item1);
                }
            }
            catch (Exception excep)
            {

            }
            load.Hide();


            //Message to User when semafor server is down.
            if (allClassification.Count == 0)
            {
                MessageBox.Show("Oops! The BOF Semafor server is down. Please try again later.");
            }

        }

        /// <summary>
        /// Browse training file click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseTrainingArff_Click(object sender, EventArgs e)
        {
            DialogResult result = openTrainingFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                trainingFilePath.Text = openTrainingFileDialog.FileName.ToString();
            }
        }

        /// <summary>
        /// Browse input file click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseInputFile_Click(object sender, EventArgs e)
        {
            DialogResult result = browseLocalFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputFilePath.Text = browseLocalFile.FileName.ToString();
                importLocalReviews();
                numberOfReviews.Text = userReviews.Count + " Reviews Imported";
            }
        }

        /// <summary>
        /// Import local reviews
        /// </summary>
        private void importLocalReviews()
        {
            userReviews = new List<string>();
            try
            {
                using (StreamReader r = new StreamReader(inputFilePath.Text))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        userReviews.Add(line);
                    }
                }
                reviewListBox.DataSource = null;
                reviewListBox.Update();
                reviewListBox.DataSource = userReviews;
                reviewListBox.Update();

            }
            catch (Exception ex)
            {
                MessageBox.Show("File Path Error");

            }
        }

        /// <summary>
        /// Classify all and export click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classifyAllAndExport_Click(object sender, EventArgs e)
        {
            // If classify at sentence level is true then split sentences
            userReviewsSentenceSplit = separateIndividualSentencesToList(userReviews);
            userReviews = userReviewsSentenceSplit;

            if (customTraining.Checked && !File.Exists(trainingFilePath.Text))
            {
                MessageBox.Show("Please select a valid training file.");
            }
            else
            {
                if (!Directory.Exists(outputFilePath.Text) || reviewListBox.Items.Count == 0)
                {
                    MessageBox.Show("Please import reviews to list and select a valid output path");
                }
                else {
                    load.Show();
                    load.TextBoxValue = "         Initializing";

                    if (userReviews.Count != 0)
                    {
                        var bwClassifyAllAndExport = new BackgroundWorker();
                        bwClassifyAllAndExport.DoWork += (o, args) => classifyAllReviewsAndExport(userReviews, customTraining.Checked ? trainingFilePath.Text : null);
                        bwClassifyAllAndExport.RunWorkerCompleted += (o, args) => classifyAllAndExportUpdateControl(customTraining.Checked ? trainingFilePath.Text : null);
                        bwClassifyAllAndExport.RunWorkerAsync();
                    }
                }
            }
        }


        /// <summary>
        /// Classify all user reviews and export. Takes in a list of user reviews and training File path
        /// </summary>
        /// <param name="userReviews"></param>
        /// <param name="trainingFilePath"></param>
        private void classifyAllReviewsAndExport(List<string> userReviews, string trainingFilePath)
        {
            WekaClassifier.WekaClassifier classifier;
            allClassification = new List<string>();
            if (boFramesClassification.Checked)
            {

                //Server Test
                FrameNetOnline.FrameNetOnline frameNetServerTest = new FrameNetOnline.FrameNetOnline("This is a test.");

                //if server test passes (returns more than 0 frames) then proceed with frame extraction.
                if (frameNetServerTest.output.Count != 0)
                {



                    listOfReviewsBoF = new List<List<string>>();
                    currentReviewIndex = 0;
                    foreach (string review in userReviews)
                    {
                        currentReviewIndex++;
                        FrameNetOnline.FrameNetOnline abc = new FrameNetOnline.FrameNetOnline(review);
                        listOfReviewsBoF.Add(abc.output);
                        BeginInvoke(new MethodInvoker(updateLoadingTextFrames));
                    }
                    BeginInvoke(new MethodInvoker(updateLoadingTextClassifier));


                    try
                    {
                        classifier = new WekaClassifier.WekaClassifier(listOfReviewsBoF, trainingFilePath, Application.StartupPath);
                        

                        foreach (string data in classifier.AllClassification)
                        {
                            allClassification.Add(data);
                        }



                        StreamWriter brWriter = new StreamWriter(outputFilePath.Text + "\\Bug Report Output.txt");
                        StreamWriter frWriter = new StreamWriter(outputFilePath.Text + "\\Feature Request Output.txt");
                        StreamWriter otWriter = new StreamWriter(outputFilePath.Text + "\\Other Output.txt");

                        int counter = -1;
                        foreach (string review in userReviews)
                        {
                            counter++;
                            if (allClassification.ElementAt(counter) == "Bug Report")
                            {
                                brWriter.WriteLine(userReviews.ElementAt(counter));
                            }
                            else if (allClassification.ElementAt(counter) == "Feature Request")
                            {
                                frWriter.WriteLine(userReviews.ElementAt(counter));
                            }
                            else
                            {
                                otWriter.WriteLine(userReviews.ElementAt(counter));
                            }
                        }

                        brWriter.Close();
                        frWriter.Close();
                        otWriter.Close();

                        //using (StreamWriter w = File.AppendText(outputFilePath.Text + "\\output.txt"))
                        //{
                        //    for (int i = 0; i < userReviews.Count; i++)
                        //    {
                        //        w.WriteLine("'" + userReviews.ElementAt(i) + "', " + allClassification.ElementAt(i));
                        //    }
                        //}

                    }
                    catch (Exception e)
                    {
                        exceptionMessage = e.ToString();
                        BeginInvoke(new MethodInvoker(exceptionMessageHandler));
                    }

                }
            }
            else if (boWordsClassification.Checked)
            {
                filteredReviews = new List<string>();
                foreach (string review in userReviews)
                {
                    filteredReviews.Add(FilterText(review));
                }


                BeginInvoke(new MethodInvoker(updateLoadingTextClassifier));
                try
                {
                    classifier = new WekaClassifier.WekaClassifier(filteredReviews, trainingFilePath, Application.StartupPath);

                    

                    foreach (string data in classifier.AllClassification)
                    {
                        allClassification.Add(data);
                    }


                    StreamWriter brWriter = new StreamWriter(outputFilePath.Text + "\\Bug Report Output.txt");
                    StreamWriter frWriter = new StreamWriter(outputFilePath.Text + "\\Feature Request Output.txt");
                    StreamWriter otWriter = new StreamWriter(outputFilePath.Text + "\\Other Output.txt");

                    int counter = -1;
                    foreach (string review in userReviews)
                    {
                        counter++;
                        if (allClassification.ElementAt(counter) == "Bug Report")
                        {
                            brWriter.WriteLine(userReviews.ElementAt(counter));
                        }
                        else if (allClassification.ElementAt(counter) == "Feature Request")
                        {
                            frWriter.WriteLine(userReviews.ElementAt(counter));
                        }
                        else
                        {
                            otWriter.WriteLine(userReviews.ElementAt(counter));
                        }
                    }

                    brWriter.Close();
                    frWriter.Close();
                    otWriter.Close();

                    //using (StreamWriter w = File.AppendText(outputFilePath.Text + "\\output.txt"))
                    //{
                    //    for (int i = 0; i < userReviews.Count; i++)
                    //    {
                    //        w.WriteLine("'" + userReviews.ElementAt(i) + "', " + allClassification.ElementAt(i));
                    //    }
                    //}

                }
                catch (Exception e)
                {
                    exceptionMessage = e.ToString();
                    BeginInvoke(new MethodInvoker(exceptionMessageHandler));
                }

            }
        }


        private void updateLoadingSingleReviewFrames()
        {
            load.TextBoxValue = "Retrieving Frame " + currentReviewIndex + " of " + singleUserReview.Count();
        }

        private void updateLoadingTextFrames()
        {
            load.TextBoxValue = "Retrieving Frame " + currentReviewIndex + " of " + userReviews.Count();
        }

        private void updateLoadingTextClassifier()
        {
            load.TextBoxValue = "          Classifying";
        }

        /// <summary>
        /// Show Exception Message
        /// </summary>
        private void exceptionMessageHandler()
        {
            MessageBox.Show( /*exceptionMessage +*/ "\n\nPlease make sure training file is in correct format. Refer to Readme file.");
        }

        /// <summary>
        /// Classify all and Export Update Control
        /// </summary>
        /// <param name="trainingFilePath"></param>
        private void classifyAllAndExportUpdateControl(string trainingFilePath)
        {
            load.Hide();

            //Message to User when semafor server is down.
            if (allClassification.Count == 0)
            {
                MessageBox.Show("Oops! The BOF Semafor server is down. Please try again later.");
            }
            else {
                Process.Start("explorer.exe", outputFilePath.Text);
            }
        }

        /// <summary>
        /// Browse output File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseOutputPath_Click(object sender, EventArgs e)
        {
            if (browseOutputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFilePath.Text = browseOutputFolderDialog.SelectedPath;
            }
        }

        /// <summary>
        /// This method breaks string to sentences separated by . and return a new list of induvidual sentences.
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        private static List<string> separateIndividualSentencesToList(List<string> inputList)
        {
            List<string> outputList = new List<string>();
            List<string> temp = new List<string>();
            foreach (string line in inputList)
            {
                temp = line.Split('.').ToList();
                foreach (string sentence in temp)
                {
                    // Minimum sentence length
                    if (sentence.Length > 0)
                    {
                        if (sentence.StartsWith(" "))
                        {
                            outputList.Add(sentence.Trim());
                        }
                        else {
                            outputList.Add(sentence);
                        }
                    }
                }
            }
            return outputList;
        }

        /// <summary>
        /// Review List Box Selection Change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reviewListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            singleUserReviewListView.Clear();
            singleUserReviewListView.View = View.Details;
            singleUserReviewListView.SmallImageList = imagelist;
            singleUserReviewListView.Columns.Add("Classification Type", 100, HorizontalAlignment.Center);
            singleUserReviewListView.Columns.Add("Text", -2, HorizontalAlignment.Left);

            try
            {
                List<string> temp = new List<string>();
                temp = reviewListBox.SelectedItem.ToString().Split('.').ToList();
                singleUserReview = new List<string>();

                foreach (string singleSentence in temp)
                {
                    if (singleSentence.Length > 0)
                    {
                        singleUserReview.Add(singleSentence);
                        var item1 = new ListViewItem(new[] { "   Unknown", singleSentence });
                        item1.ImageIndex = 2;
                        singleUserReviewListView.Items.Add(item1);
                    }
                }
            }
            catch (Exception exc)
            {
            }
        }


    }
}
