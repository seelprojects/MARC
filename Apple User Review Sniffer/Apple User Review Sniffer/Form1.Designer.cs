namespace Apple_User_Review_Sniffer
{
    partial class Form1
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
            this.appIDLabel = new System.Windows.Forms.Label();
            this.appleIDLabel = new System.Windows.Forms.TextBox();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.importComments = new System.Windows.Forms.Button();
            this.reviewListBox = new System.Windows.Forms.ListBox();
            this.exportComments = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.numPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appIDLabel
            // 
            this.appIDLabel.AutoSize = true;
            this.appIDLabel.Location = new System.Drawing.Point(129, 44);
            this.appIDLabel.Name = "appIDLabel";
            this.appIDLabel.Size = new System.Drawing.Size(249, 20);
            this.appIDLabel.TabIndex = 0;
            this.appIDLabel.Text = "Step 1: Enter Apple Store App ID:";
            // 
            // appleIDLabel
            // 
            this.appleIDLabel.Location = new System.Drawing.Point(384, 41);
            this.appleIDLabel.Multiline = true;
            this.appleIDLabel.Name = "appleIDLabel";
            this.appleIDLabel.Size = new System.Drawing.Size(187, 32);
            this.appleIDLabel.TabIndex = 1;
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(33, 172);
            this.horizontalLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(915, 10);
            this.horizontalLine.TabIndex = 16;
            // 
            // importComments
            // 
            this.importComments.Location = new System.Drawing.Point(661, 56);
            this.importComments.Name = "importComments";
            this.importComments.Size = new System.Drawing.Size(266, 72);
            this.importComments.TabIndex = 17;
            this.importComments.Text = "Import Comments";
            this.importComments.UseVisualStyleBackColor = true;
            this.importComments.Click += new System.EventHandler(this.importComments_Click);
            // 
            // reviewListBox
            // 
            this.reviewListBox.FormattingEnabled = true;
            this.reviewListBox.ItemHeight = 20;
            this.reviewListBox.Location = new System.Drawing.Point(33, 195);
            this.reviewListBox.Name = "reviewListBox";
            this.reviewListBox.Size = new System.Drawing.Size(915, 404);
            this.reviewListBox.TabIndex = 18;
            // 
            // exportComments
            // 
            this.exportComments.Location = new System.Drawing.Point(757, 619);
            this.exportComments.Name = "exportComments";
            this.exportComments.Size = new System.Drawing.Size(191, 81);
            this.exportComments.TabIndex = 19;
            this.exportComments.Text = "Export Comments";
            this.exportComments.UseVisualStyleBackColor = true;
            this.exportComments.Click += new System.EventHandler(this.exportComments_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(129, 105);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(385, 20);
            this.pageLabel.TabIndex = 20;
            this.pageLabel.Text = "Step 2: Enter Number of Pages (50 reviews per page)";
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(514, 102);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(57, 26);
            this.numPages.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(611, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 145);
            this.label3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Step 3: Click to Import";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Step 4: Click to Export to a text file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Default Value is 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.exportComments);
            this.Controls.Add(this.reviewListBox);
            this.Controls.Add(this.importComments);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.appleIDLabel);
            this.Controls.Add(this.appIDLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appIDLabel;
        private System.Windows.Forms.TextBox appleIDLabel;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Button importComments;
        private System.Windows.Forms.ListBox reviewListBox;
        private System.Windows.Forms.Button exportComments;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.TextBox numPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

