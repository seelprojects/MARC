namespace Master_ARC_1
{
    partial class AppIdClassification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppIdClassification));
            this.appIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.importReviews = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.numberOfReviewsCombo = new MetroFramework.Controls.MetroComboBox();
            this.reviewListBox = new System.Windows.Forms.ListBox();
            this.numberOfReviews = new MetroFramework.Controls.MetroLabel();
            this.inputFilePath = new MetroFramework.Controls.MetroTextBox();
            this.browseInputFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.boFramesClassification = new MetroFramework.Controls.MetroCheckBox();
            this.browseTrainingArff = new MetroFramework.Controls.MetroButton();
            this.boWordsClassification = new MetroFramework.Controls.MetroCheckBox();
            this.trainingFilePath = new MetroFramework.Controls.MetroTextBox();
            this.customTraining = new MetroFramework.Controls.MetroCheckBox();
            this.defaultTraining = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.browseOutputPath = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.outputFilePath = new MetroFramework.Controls.MetroTextBox();
            this.classifyAllAndExport = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.classifyCurrentReview = new MetroFramework.Controls.MetroButton();
            this.openTrainingFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.supportVectorCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.naiveBayesCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.removeStopwordsCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.stemmingCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.singleUserReviewListView = new System.Windows.Forms.ListView();
            this.browseLocalFile = new System.Windows.Forms.OpenFileDialog();
            this.browseOutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // appIdTextBox
            // 
            this.appIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.appIdTextBox.CustomButton.Image = null;
            this.appIdTextBox.CustomButton.Location = new System.Drawing.Point(144, 2);
            this.appIdTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.appIdTextBox.CustomButton.Name = "";
            this.appIdTextBox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.appIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.appIdTextBox.CustomButton.TabIndex = 1;
            this.appIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.appIdTextBox.CustomButton.UseSelectable = true;
            this.appIdTextBox.CustomButton.Visible = false;
            this.appIdTextBox.Lines = new string[0];
            this.appIdTextBox.Location = new System.Drawing.Point(123, 39);
            this.appIdTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.appIdTextBox.MaxLength = 32767;
            this.appIdTextBox.Multiline = true;
            this.appIdTextBox.Name = "appIdTextBox";
            this.appIdTextBox.PasswordChar = '\0';
            this.appIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.appIdTextBox.SelectedText = "";
            this.appIdTextBox.SelectionLength = 0;
            this.appIdTextBox.SelectionStart = 0;
            this.appIdTextBox.Size = new System.Drawing.Size(166, 24);
            this.appIdTextBox.TabIndex = 0;
            this.appIdTextBox.UseSelectable = true;
            this.appIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.appIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // importReviews
            // 
            this.importReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importReviews.Location = new System.Drawing.Point(473, 39);
            this.importReviews.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.importReviews.Name = "importReviews";
            this.importReviews.Size = new System.Drawing.Size(61, 24);
            this.importReviews.TabIndex = 1;
            this.importReviews.Text = "Import";
            this.importReviews.UseSelectable = true;
            this.importReviews.Click += new System.EventHandler(this.importReviews_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 41);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "iOS App ID:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.numberOfReviewsCombo);
            this.metroPanel1.Controls.Add(this.reviewListBox);
            this.metroPanel1.Controls.Add(this.numberOfReviews);
            this.metroPanel1.Controls.Add(this.inputFilePath);
            this.metroPanel1.Controls.Add(this.browseInputFile);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.importReviews);
            this.metroPanel1.Controls.Add(this.appIdTextBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 6;
            this.metroPanel1.Location = new System.Drawing.Point(14, 8);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(580, 312);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(43, 135);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(154, 25);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Imported Reviews";
            // 
            // numberOfReviewsCombo
            // 
            this.numberOfReviewsCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfReviewsCombo.FormattingEnabled = true;
            this.numberOfReviewsCombo.ItemHeight = 23;
            this.numberOfReviewsCombo.Location = new System.Drawing.Point(417, 37);
            this.numberOfReviewsCombo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numberOfReviewsCombo.Name = "numberOfReviewsCombo";
            this.numberOfReviewsCombo.Size = new System.Drawing.Size(53, 29);
            this.numberOfReviewsCombo.TabIndex = 37;
            this.numberOfReviewsCombo.UseSelectable = true;
            // 
            // reviewListBox
            // 
            this.reviewListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reviewListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reviewListBox.FormattingEnabled = true;
            this.reviewListBox.Location = new System.Drawing.Point(43, 164);
            this.reviewListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.reviewListBox.Name = "reviewListBox";
            this.reviewListBox.Size = new System.Drawing.Size(491, 134);
            this.reviewListBox.TabIndex = 27;
            this.reviewListBox.SelectedIndexChanged += new System.EventHandler(this.reviewListBox_SelectedIndexChanged_1);
            // 
            // numberOfReviews
            // 
            this.numberOfReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberOfReviews.AutoSize = true;
            this.numberOfReviews.Location = new System.Drawing.Point(400, 143);
            this.numberOfReviews.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfReviews.Name = "numberOfReviews";
            this.numberOfReviews.Size = new System.Drawing.Size(125, 19);
            this.numberOfReviews.TabIndex = 27;
            this.numberOfReviews.Text = "0 Reviews Imported";
            // 
            // inputFilePath
            // 
            this.inputFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.inputFilePath.CustomButton.Image = null;
            this.inputFilePath.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.inputFilePath.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputFilePath.CustomButton.Name = "";
            this.inputFilePath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.inputFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputFilePath.CustomButton.TabIndex = 1;
            this.inputFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputFilePath.CustomButton.UseSelectable = true;
            this.inputFilePath.CustomButton.Visible = false;
            this.inputFilePath.Lines = new string[0];
            this.inputFilePath.Location = new System.Drawing.Point(123, 89);
            this.inputFilePath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputFilePath.MaxLength = 32767;
            this.inputFilePath.Multiline = true;
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.PasswordChar = '\0';
            this.inputFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputFilePath.SelectedText = "";
            this.inputFilePath.SelectionLength = 0;
            this.inputFilePath.SelectionStart = 0;
            this.inputFilePath.Size = new System.Drawing.Size(346, 24);
            this.inputFilePath.TabIndex = 41;
            this.inputFilePath.UseSelectable = true;
            this.inputFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browseInputFile
            // 
            this.browseInputFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseInputFile.Location = new System.Drawing.Point(473, 89);
            this.browseInputFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.browseInputFile.Name = "browseInputFile";
            this.browseInputFile.Size = new System.Drawing.Size(61, 24);
            this.browseInputFile.TabIndex = 40;
            this.browseInputFile.Text = "Browse";
            this.browseInputFile.UseSelectable = true;
            this.browseInputFile.Click += new System.EventHandler(this.browseInputFile_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(45, 92);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(65, 19);
            this.metroLabel11.TabIndex = 39;
            this.metroLabel11.Text = "Input File:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(67, 66);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(22, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "or";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(39, 3);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 25);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Import Reviews";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(293, 41);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Number of Reviews:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(326, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 84);
            this.label3.TabIndex = 35;
            // 
            // boFramesClassification
            // 
            this.boFramesClassification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boFramesClassification.AutoSize = true;
            this.boFramesClassification.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.boFramesClassification.Location = new System.Drawing.Point(146, 49);
            this.boFramesClassification.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.boFramesClassification.Name = "boFramesClassification";
            this.boFramesClassification.Size = new System.Drawing.Size(112, 19);
            this.boFramesClassification.TabIndex = 34;
            this.boFramesClassification.Text = "Bag of Frames";
            this.boFramesClassification.UseSelectable = true;
            // 
            // browseTrainingArff
            // 
            this.browseTrainingArff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseTrainingArff.Location = new System.Drawing.Point(507, 101);
            this.browseTrainingArff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.browseTrainingArff.Name = "browseTrainingArff";
            this.browseTrainingArff.Size = new System.Drawing.Size(61, 21);
            this.browseTrainingArff.TabIndex = 32;
            this.browseTrainingArff.Text = "Browse";
            this.browseTrainingArff.UseSelectable = true;
            this.browseTrainingArff.Click += new System.EventHandler(this.browseTrainingArff_Click);
            // 
            // boWordsClassification
            // 
            this.boWordsClassification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boWordsClassification.AutoSize = true;
            this.boWordsClassification.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.boWordsClassification.Location = new System.Drawing.Point(146, 72);
            this.boWordsClassification.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.boWordsClassification.Name = "boWordsClassification";
            this.boWordsClassification.Size = new System.Drawing.Size(107, 19);
            this.boWordsClassification.TabIndex = 33;
            this.boWordsClassification.Text = "Bag of Words";
            this.boWordsClassification.UseSelectable = true;
            // 
            // trainingFilePath
            // 
            this.trainingFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.trainingFilePath.CustomButton.Image = null;
            this.trainingFilePath.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.trainingFilePath.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.trainingFilePath.CustomButton.Name = "";
            this.trainingFilePath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.trainingFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.trainingFilePath.CustomButton.TabIndex = 1;
            this.trainingFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.trainingFilePath.CustomButton.UseSelectable = true;
            this.trainingFilePath.CustomButton.Visible = false;
            this.trainingFilePath.Lines = new string[0];
            this.trainingFilePath.Location = new System.Drawing.Point(364, 101);
            this.trainingFilePath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.trainingFilePath.MaxLength = 32767;
            this.trainingFilePath.Multiline = true;
            this.trainingFilePath.Name = "trainingFilePath";
            this.trainingFilePath.PasswordChar = '\0';
            this.trainingFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.trainingFilePath.SelectedText = "";
            this.trainingFilePath.SelectionLength = 0;
            this.trainingFilePath.SelectionStart = 0;
            this.trainingFilePath.Size = new System.Drawing.Size(139, 21);
            this.trainingFilePath.TabIndex = 31;
            this.trainingFilePath.UseSelectable = true;
            this.trainingFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.trainingFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customTraining
            // 
            this.customTraining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTraining.AutoSize = true;
            this.customTraining.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.customTraining.Location = new System.Drawing.Point(349, 72);
            this.customTraining.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.customTraining.Name = "customTraining";
            this.customTraining.Size = new System.Drawing.Size(125, 19);
            this.customTraining.TabIndex = 30;
            this.customTraining.Text = "Custom Training";
            this.customTraining.UseSelectable = true;
            // 
            // defaultTraining
            // 
            this.defaultTraining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defaultTraining.AutoSize = true;
            this.defaultTraining.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.defaultTraining.Location = new System.Drawing.Point(349, 49);
            this.defaultTraining.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.defaultTraining.Name = "defaultTraining";
            this.defaultTraining.Size = new System.Drawing.Size(121, 19);
            this.defaultTraining.TabIndex = 29;
            this.defaultTraining.Text = "Default Training";
            this.defaultTraining.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(45, 11);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(183, 25);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Classification Settings";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.browseOutputPath);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.outputFilePath);
            this.metroPanel2.Controls.Add(this.classifyAllAndExport);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 6;
            this.metroPanel2.Location = new System.Drawing.Point(14, 725);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(580, 96);
            this.metroPanel2.TabIndex = 28;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 7;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(49, 19);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(254, 25);
            this.metroLabel9.TabIndex = 47;
            this.metroLabel9.Text = "Classify All Reviews and Export";
            // 
            // browseOutputPath
            // 
            this.browseOutputPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseOutputPath.Location = new System.Drawing.Point(345, 50);
            this.browseOutputPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.browseOutputPath.Name = "browseOutputPath";
            this.browseOutputPath.Size = new System.Drawing.Size(57, 24);
            this.browseOutputPath.TabIndex = 36;
            this.browseOutputPath.Text = "Browse";
            this.browseOutputPath.UseSelectable = true;
            this.browseOutputPath.Click += new System.EventHandler(this.browseOutputPath_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(51, 55);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 15);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Output File Path:";
            // 
            // outputFilePath
            // 
            this.outputFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.outputFilePath.CustomButton.Image = null;
            this.outputFilePath.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.outputFilePath.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputFilePath.CustomButton.Name = "";
            this.outputFilePath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.outputFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputFilePath.CustomButton.TabIndex = 1;
            this.outputFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputFilePath.CustomButton.UseSelectable = true;
            this.outputFilePath.CustomButton.Visible = false;
            this.outputFilePath.Lines = new string[0];
            this.outputFilePath.Location = new System.Drawing.Point(143, 50);
            this.outputFilePath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputFilePath.MaxLength = 32767;
            this.outputFilePath.Multiline = true;
            this.outputFilePath.Name = "outputFilePath";
            this.outputFilePath.PasswordChar = '\0';
            this.outputFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputFilePath.SelectedText = "";
            this.outputFilePath.SelectionLength = 0;
            this.outputFilePath.SelectionStart = 0;
            this.outputFilePath.Size = new System.Drawing.Size(198, 24);
            this.outputFilePath.TabIndex = 42;
            this.outputFilePath.UseSelectable = true;
            this.outputFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // classifyAllAndExport
            // 
            this.classifyAllAndExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classifyAllAndExport.Location = new System.Drawing.Point(406, 50);
            this.classifyAllAndExport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.classifyAllAndExport.Name = "classifyAllAndExport";
            this.classifyAllAndExport.Size = new System.Drawing.Size(134, 24);
            this.classifyAllAndExport.TabIndex = 41;
            this.classifyAllAndExport.Text = "Classify All and Export";
            this.classifyAllAndExport.UseSelectable = true;
            this.classifyAllAndExport.Click += new System.EventHandler(this.classifyAllAndExport_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(45, 15);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(183, 25);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Classify Single Review";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(51, 50);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 15);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Select a review from above list";
            // 
            // classifyCurrentReview
            // 
            this.classifyCurrentReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classifyCurrentReview.Location = new System.Drawing.Point(389, 196);
            this.classifyCurrentReview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.classifyCurrentReview.Name = "classifyCurrentReview";
            this.classifyCurrentReview.Size = new System.Drawing.Size(145, 21);
            this.classifyCurrentReview.TabIndex = 36;
            this.classifyCurrentReview.Text = "Classify Selected Review";
            this.classifyCurrentReview.UseSelectable = true;
            this.classifyCurrentReview.Click += new System.EventHandler(this.classifyCurrentReview_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.Controls.Add(this.supportVectorCheckbox);
            this.metroPanel3.Controls.Add(this.naiveBayesCheckbox);
            this.metroPanel3.Controls.Add(this.removeStopwordsCheckbox);
            this.metroPanel3.Controls.Add(this.stemmingCheckBox);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.defaultTraining);
            this.metroPanel3.Controls.Add(this.boFramesClassification);
            this.metroPanel3.Controls.Add(this.customTraining);
            this.metroPanel3.Controls.Add(this.browseTrainingArff);
            this.metroPanel3.Controls.Add(this.trainingFilePath);
            this.metroPanel3.Controls.Add(this.boWordsClassification);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 6;
            this.metroPanel3.Location = new System.Drawing.Point(14, 330);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(580, 142);
            this.metroPanel3.TabIndex = 37;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(118, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 84);
            this.label1.TabIndex = 40;
            // 
            // supportVectorCheckbox
            // 
            this.supportVectorCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supportVectorCheckbox.AutoSize = true;
            this.supportVectorCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.supportVectorCheckbox.Location = new System.Drawing.Point(49, 50);
            this.supportVectorCheckbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.supportVectorCheckbox.Name = "supportVectorCheckbox";
            this.supportVectorCheckbox.Size = new System.Drawing.Size(54, 19);
            this.supportVectorCheckbox.TabIndex = 39;
            this.supportVectorCheckbox.Text = "SVM";
            this.supportVectorCheckbox.UseSelectable = true;
            // 
            // naiveBayesCheckbox
            // 
            this.naiveBayesCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naiveBayesCheckbox.AutoSize = true;
            this.naiveBayesCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.naiveBayesCheckbox.Location = new System.Drawing.Point(49, 72);
            this.naiveBayesCheckbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.naiveBayesCheckbox.Name = "naiveBayesCheckbox";
            this.naiveBayesCheckbox.Size = new System.Drawing.Size(43, 19);
            this.naiveBayesCheckbox.TabIndex = 38;
            this.naiveBayesCheckbox.Text = "NB";
            this.naiveBayesCheckbox.UseSelectable = true;
            // 
            // removeStopwordsCheckbox
            // 
            this.removeStopwordsCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeStopwordsCheckbox.AutoSize = true;
            this.removeStopwordsCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.removeStopwordsCheckbox.Location = new System.Drawing.Point(160, 95);
            this.removeStopwordsCheckbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.removeStopwordsCheckbox.Name = "removeStopwordsCheckbox";
            this.removeStopwordsCheckbox.Size = new System.Drawing.Size(143, 19);
            this.removeStopwordsCheckbox.TabIndex = 37;
            this.removeStopwordsCheckbox.Text = "Remove Stopwords";
            this.removeStopwordsCheckbox.UseSelectable = true;
            // 
            // stemmingCheckBox
            // 
            this.stemmingCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stemmingCheckBox.AutoSize = true;
            this.stemmingCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.stemmingCheckBox.Location = new System.Drawing.Point(160, 115);
            this.stemmingCheckBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.stemmingCheckBox.Name = "stemmingCheckBox";
            this.stemmingCheckBox.Size = new System.Drawing.Size(87, 19);
            this.stemmingCheckBox.TabIndex = 36;
            this.stemmingCheckBox.Text = "Stemming";
            this.stemmingCheckBox.UseSelectable = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel5.Controls.Add(this.singleUserReviewListView);
            this.metroPanel5.Controls.Add(this.classifyCurrentReview);
            this.metroPanel5.Controls.Add(this.metroLabel8);
            this.metroPanel5.Controls.Add(this.metroLabel3);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 6;
            this.metroPanel5.Location = new System.Drawing.Point(14, 488);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(580, 227);
            this.metroPanel5.TabIndex = 38;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 7;
            // 
            // singleUserReviewListView
            // 
            this.singleUserReviewListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.singleUserReviewListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.singleUserReviewListView.AutoArrange = false;
            this.singleUserReviewListView.FullRowSelect = true;
            this.singleUserReviewListView.GridLines = true;
            this.singleUserReviewListView.HideSelection = false;
            this.singleUserReviewListView.LabelWrap = false;
            this.singleUserReviewListView.Location = new System.Drawing.Point(51, 70);
            this.singleUserReviewListView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.singleUserReviewListView.Name = "singleUserReviewListView";
            this.singleUserReviewListView.ShowGroups = false;
            this.singleUserReviewListView.ShowItemToolTips = true;
            this.singleUserReviewListView.Size = new System.Drawing.Size(484, 124);
            this.singleUserReviewListView.TabIndex = 46;
            this.singleUserReviewListView.UseCompatibleStateImageBehavior = false;
            // 
            // AppIdClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 831);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel3);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AppIdClassification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARC 1.0 - Mobile App Review Classifier";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox appIdTextBox;
        private MetroFramework.Controls.MetroButton importReviews;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox reviewListBox;
        private MetroFramework.Controls.MetroLabel numberOfReviews;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton classifyCurrentReview;
        private MetroFramework.Controls.MetroButton classifyAllAndExport;
        private MetroFramework.Controls.MetroButton browseOutputPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox outputFilePath;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.OpenFileDialog openTrainingFileDialog;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox defaultTraining;
        private MetroFramework.Controls.MetroCheckBox customTraining;
        private MetroFramework.Controls.MetroTextBox trainingFilePath;
        private MetroFramework.Controls.MetroCheckBox boWordsClassification;
        private MetroFramework.Controls.MetroButton browseTrainingArff;
        private MetroFramework.Controls.MetroCheckBox boFramesClassification;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox numberOfReviewsCombo;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton browseInputFile;
        private MetroFramework.Controls.MetroTextBox inputFilePath;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.OpenFileDialog browseLocalFile;
        private System.Windows.Forms.FolderBrowserDialog browseOutputFolderDialog;
        private MetroFramework.Controls.MetroCheckBox stemmingCheckBox;
        private MetroFramework.Controls.MetroCheckBox removeStopwordsCheckbox;
        private System.Windows.Forms.ListView singleUserReviewListView;
        private MetroFramework.Controls.MetroCheckBox supportVectorCheckbox;
        private MetroFramework.Controls.MetroCheckBox naiveBayesCheckbox;
        private System.Windows.Forms.Label label1;
    }
}