
namespace YoutubeDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxMp4 = new System.Windows.Forms.CheckBox();
            this.checkBoxMp3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxInstantDownload = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSavePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxUrlCapture = new System.Windows.Forms.CheckBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelBitrate = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimaze = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSavepath = new System.Windows.Forms.PictureBox();
            this.pictureBoxDownload = new System.Windows.Forms.PictureBox();
            this.PictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSavepath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.textBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUrl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.ForeColor = System.Drawing.Color.White;
            this.textBoxUrl.Location = new System.Drawing.Point(102, 52);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(472, 24);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(101, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 3);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitrate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration:";
            // 
            // checkBoxMp4
            // 
            this.checkBoxMp4.AutoSize = true;
            this.checkBoxMp4.ForeColor = System.Drawing.Color.White;
            this.checkBoxMp4.Location = new System.Drawing.Point(299, 256);
            this.checkBoxMp4.Name = "checkBoxMp4";
            this.checkBoxMp4.Size = new System.Drawing.Size(65, 24);
            this.checkBoxMp4.TabIndex = 8;
            this.checkBoxMp4.Text = "Mp4";
            this.checkBoxMp4.UseVisualStyleBackColor = true;
            // 
            // checkBoxMp3
            // 
            this.checkBoxMp3.AutoSize = true;
            this.checkBoxMp3.ForeColor = System.Drawing.Color.White;
            this.checkBoxMp3.Location = new System.Drawing.Point(376, 256);
            this.checkBoxMp3.Name = "checkBoxMp3";
            this.checkBoxMp3.Size = new System.Drawing.Size(65, 24);
            this.checkBoxMp3.TabIndex = 9;
            this.checkBoxMp3.Text = "Mp3";
            this.checkBoxMp3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxInfo);
            this.groupBox1.Controls.Add(this.pictureBoxInfo);
            this.groupBox1.Controls.Add(this.checkBoxInstantDownload);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBoxSavepath);
            this.groupBox1.Controls.Add(this.labelSavePath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBoxUrlCapture);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxInfo.Location = new System.Drawing.Point(231, 33);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(355, 67);
            this.groupBoxInfo.TabIndex = 22;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            this.groupBoxInfo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mp4 or Mp3 options must be selected to download";
            // 
            // checkBoxInstantDownload
            // 
            this.checkBoxInstantDownload.AutoSize = true;
            this.checkBoxInstantDownload.Location = new System.Drawing.Point(206, 26);
            this.checkBoxInstantDownload.Name = "checkBoxInstantDownload";
            this.checkBoxInstantDownload.Size = new System.Drawing.Size(166, 24);
            this.checkBoxInstantDownload.TabIndex = 20;
            this.checkBoxInstantDownload.Text = "Instant Download";
            this.checkBoxInstantDownload.UseVisualStyleBackColor = true;
            this.checkBoxInstantDownload.CheckedChanged += new System.EventHandler(this.checkBoxInstantDownload_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(442, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Furkan AYYILDIZ";
            // 
            // labelSavePath
            // 
            this.labelSavePath.AutoSize = true;
            this.labelSavePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSavePath.Location = new System.Drawing.Point(166, 68);
            this.labelSavePath.Name = "labelSavePath";
            this.labelSavePath.Size = new System.Drawing.Size(43, 20);
            this.labelSavePath.TabIndex = 2;
            this.labelSavePath.Text = "Path";
            this.labelSavePath.Click += new System.EventHandler(this.labelSavePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Save Path :";
            // 
            // checkBoxUrlCapture
            // 
            this.checkBoxUrlCapture.AutoSize = true;
            this.checkBoxUrlCapture.Checked = true;
            this.checkBoxUrlCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUrlCapture.Location = new System.Drawing.Point(37, 26);
            this.checkBoxUrlCapture.Name = "checkBoxUrlCapture";
            this.checkBoxUrlCapture.Size = new System.Drawing.Size(123, 24);
            this.checkBoxUrlCapture.TabIndex = 0;
            this.checkBoxUrlCapture.Text = "Url Capture";
            this.checkBoxUrlCapture.UseVisualStyleBackColor = true;
            this.checkBoxUrlCapture.CheckStateChanged += new System.EventHandler(this.checkBoxUrlCapture_CheckStateChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.pictureBoxMinimaze);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 26);
            this.panelTop.TabIndex = 14;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(214, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Youtube Downloader";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(365, 122);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(0, 20);
            this.LabelName.TabIndex = 15;
            // 
            // LabelBitrate
            // 
            this.LabelBitrate.AutoSize = true;
            this.LabelBitrate.ForeColor = System.Drawing.Color.White;
            this.LabelBitrate.Location = new System.Drawing.Point(365, 169);
            this.LabelBitrate.Name = "LabelBitrate";
            this.LabelBitrate.Size = new System.Drawing.Size(0, 20);
            this.LabelBitrate.TabIndex = 16;
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.ForeColor = System.Drawing.Color.White;
            this.LabelDuration.Location = new System.Drawing.Point(377, 216);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(0, 20);
            this.LabelDuration.TabIndex = 17;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.LabelWarning.Location = new System.Drawing.Point(98, 81);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 20);
            this.LabelWarning.TabIndex = 18;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Location = new System.Drawing.Point(516, 248);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(55, 37);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatus.TabIndex = 19;
            this.pictureBoxStatus.TabStop = false;
            // 
            // pictureBoxMinimaze
            // 
            this.pictureBoxMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimaze.Image = global::YoutubeDownloader.Properties.Resources.Minimazepng;
            this.pictureBoxMinimaze.Location = new System.Drawing.Point(518, 0);
            this.pictureBoxMinimaze.Name = "pictureBoxMinimaze";
            this.pictureBoxMinimaze.Size = new System.Drawing.Size(45, 24);
            this.pictureBoxMinimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimaze.TabIndex = 13;
            this.pictureBoxMinimaze.TabStop = false;
            this.pictureBoxMinimaze.Click += new System.EventHandler(this.pictureBoxMinimaze_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::YoutubeDownloader.Properties.Resources.closepng;
            this.pictureBoxClose.Location = new System.Drawing.Point(569, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(29, 24);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 12;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfo.Image = global::YoutubeDownloader.Properties.Resources.Information_icon;
            this.pictureBoxInfo.Location = new System.Drawing.Point(335, 9);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(18, 24);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 21;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.MouseLeave += new System.EventHandler(this.pictureBoxInfo_MouseLeave);
            this.pictureBoxInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInfo_MouseMove);
            // 
            // pictureBoxSavepath
            // 
            this.pictureBoxSavepath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSavepath.Image = global::YoutubeDownloader.Properties.Resources.folder_white_256;
            this.pictureBoxSavepath.Location = new System.Drawing.Point(28, 62);
            this.pictureBoxSavepath.Name = "pictureBoxSavepath";
            this.pictureBoxSavepath.Size = new System.Drawing.Size(43, 24);
            this.pictureBoxSavepath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSavepath.TabIndex = 3;
            this.pictureBoxSavepath.TabStop = false;
            this.pictureBoxSavepath.Click += new System.EventHandler(this.pictureBoxSavepath_Click);
            // 
            // pictureBoxDownload
            // 
            this.pictureBoxDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDownload.Image = global::YoutubeDownloader.Properties.Resources.download32;
            this.pictureBoxDownload.Location = new System.Drawing.Point(444, 248);
            this.pictureBoxDownload.Name = "pictureBoxDownload";
            this.pictureBoxDownload.Size = new System.Drawing.Size(82, 36);
            this.pictureBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDownload.TabIndex = 10;
            this.pictureBoxDownload.TabStop = false;
            this.pictureBoxDownload.Click += new System.EventHandler(this.pictureBoxDownload_Click);
            this.pictureBoxDownload.MouseLeave += new System.EventHandler(this.pictureBoxDownload_MouseLeave);
            this.pictureBoxDownload.MouseHover += new System.EventHandler(this.pictureBoxDownload_MouseHover);
            // 
            // PictureBoxSettings
            // 
            this.PictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSettings.ErrorImage = null;
            this.PictureBoxSettings.Image = global::YoutubeDownloader.Properties.Resources.Setting32;
            this.PictureBoxSettings.Location = new System.Drawing.Point(12, 248);
            this.PictureBoxSettings.Name = "PictureBoxSettings";
            this.PictureBoxSettings.Size = new System.Drawing.Size(36, 37);
            this.PictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxSettings.TabIndex = 7;
            this.PictureBoxSettings.TabStop = false;
            this.PictureBoxSettings.Click += new System.EventHandler(this.PictureBoxSettings_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.Location = new System.Drawing.Point(48, 117);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(192, 123);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 4;
            this.pictureBoxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(610, 292);
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelBitrate);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxDownload);
            this.Controls.Add(this.checkBoxMp3);
            this.Controls.Add(this.checkBoxMp4);
            this.Controls.Add(this.PictureBoxSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSavepath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxMp4;
        private System.Windows.Forms.CheckBox checkBoxMp3;
        private System.Windows.Forms.PictureBox pictureBoxDownload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUrlCapture;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxSavepath;
        private System.Windows.Forms.Label labelSavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelBitrate;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxInstantDownload;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxMinimaze;
    }
}

