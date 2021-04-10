using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region WİN 32 APİ DLL İMPORT
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        #endregion

        #region Change of location
        int Movee;
        int Mouse_X;
        int Mouse_Y;
        #endregion 
        bool BW_Proses = false;

        IntPtr NextClipboard;
        bool ReadClipboard=true;
        bool InstantDownload = false;

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";    //default path

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSavePath.Text = path;
            NextClipboard = SetClipboardViewer(this.Handle);
            
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BW_Proses = true;
            try
            {
                if (LabelWarning.Text == "" && textBoxUrl.Text != "")
                {
                    if (!checkBoxMp3.Checked && !checkBoxMp4.Checked)
                    {
                        pictureBoxStatus.Image = Properties.Resources.close;
                        return;
                    }

                    pictureBoxStatus.Image = Properties.Resources.DownloadGif;
                    Dowloader dowloader = new Dowloader(textBoxUrl.Text);
                    dowloader.VideoDownload(path);


                    if (checkBoxMp3.Checked)
                    {
                        Convert convert = new Convert();
                        convert.Mp4ToMp3(path, dowloader.VideoName);
                    }
                    if (!checkBoxMp4.Checked)
                    {
                        File.Delete($"{path + dowloader.VideoName}");
                    }
                    
                    pictureBoxStatus.Image = Properties.Resources._checked;
                    return;
                }
                else
                {
                    pictureBoxStatus.Image = Properties.Resources.close;
                }
            }
            catch (Exception)
            {
                pictureBoxStatus.Image = Properties.Resources.close;
                throw;
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BW_Proses = false;
        }

        //DOWNLOADER
        private void pictureBoxDownload_Click(object sender, EventArgs e)
        {
            if (BW_Proses==false)
            {
                backgroundWorker1.RunWorkerAsync();
            }


        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUrl.Text == "")
                {
                    LabelBitrate.Text = "";
                    LabelName.Text = "";
                    LabelDuration.Text = "";
                    pictureBoxImage.Image = null;

                    return;
                }


                LabelWarning.Text = "";
                if (textBoxUrl.Text.Contains("youtube.com"))
                {
                    LabelName.Text = "";
                    LabelBitrate.Text = "";
                    LabelDuration.Text = "";

                    Dowloader dowloader = new Dowloader(textBoxUrl.Text);
                    dowloader.GetImage();

                    LabelBitrate.Text = dowloader.Audio_Bitrate.ToString();
                    pictureBoxImage.Image = dowloader.GetImageBitmap();
                    if (dowloader.VideoName.Length >= 30)
                    {
                        LabelName.Text = dowloader.VideoName.Substring(0, 30) + "...";
                    }
                }
                else
                {
                    LabelWarning.Text = "This is not a youtube link!";
                }
            }
            catch (Exception)
            {
                LabelWarning.Text = "Not Found Video";
                //  throw;
            }






        }

        private void labelSavePath_Click(object sender, EventArgs e)
        {
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = path;
            prc.Start();
        }



        #region PictureBox 
        private void PictureBoxSettings_Click(object sender, EventArgs e)
        {
            if (base.Size.Height == 292)
                base.Size = new System.Drawing.Size(610, 390);
            else
                base.Size = new System.Drawing.Size(610, 292);
        }

        private void pictureBoxMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBoxDownload_MouseHover(object sender, EventArgs e)
        {
            pictureBoxDownload.Image = global::YoutubeDownloader.Properties.Resources.download_blue_32;
        }

        private void pictureBoxDownload_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDownload.Image = global::YoutubeDownloader.Properties.Resources.download32;
        }

        private void pictureBoxSavepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Folder = new FolderBrowserDialog();
            if (Folder.ShowDialog() == DialogResult.OK)
            {
                path = Folder.SelectedPath + @"\";
                labelSavePath.Text = Folder.SelectedPath + @"\";
            }
            else
            {
                MessageBox.Show("Please Select Folder");
            }
        }

        #endregion

        #region change of location
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Movee = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Movee = 0;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movee == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }



        #endregion


        #region CLIPBOARD READ





        protected override void WndProc(ref Message m)
        {
            int WM_DRAWCLIPBOARD = 0x0308;
            int WM_CHANGECBCHAIN = 0x030D;
            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                ClipboardRead();
                SendMessage(NextClipboard, m.Msg, m.WParam, m.LParam);
            }
            else if (m.Msg == WM_CHANGECBCHAIN)
            {
                if (m.WParam == NextClipboard)
                    NextClipboard = m.LParam;
                else
                    SendMessage(NextClipboard, m.Msg, m.WParam, m.LParam);
            }
            base.WndProc(ref m);
        }
        private void ClipboardRead()
        {
            IDataObject dObj = Clipboard.GetDataObject();
            if (dObj.GetDataPresent(DataFormats.Text))
            {
                string Clipboard = (string)dObj.GetData(DataFormats.Text);

                if (Clipboard.Contains("youtube.com") && ReadClipboard)
                {
                    textBoxUrl.Text = Clipboard;
                }

                if (InstantDownload)
                {
                    if (BW_Proses == false)
                    {
                        BW_Proses = true;
                        backgroundWorker1.RunWorkerAsync();
                    }
                }



            }
        }

        #endregion

        private void checkBoxUrlCapture_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxUrlCapture.Checked)
                ReadClipboard = false;
            else
                ReadClipboard = true;
        }

        private void checkBoxInstantDownload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInstantDownload.Checked)
            {
                checkBoxUrlCapture.Checked = true;
                InstantDownload = true;
            }
            else
            {
                InstantDownload = false;
            }
        }

        private void pictureBoxInfo_MouseMove(object sender, MouseEventArgs e)
        {
            groupBoxInfo.Visible = true;
            checkBoxInstantDownload.Visible = false;
            checkBoxUrlCapture.Visible = false;
            pictureBoxSavepath.Visible = false;
            labelSavePath.Visible = false;
            label5.Visible = false;
        }

        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            groupBoxInfo.Visible = false;
            checkBoxInstantDownload.Visible = true;
            checkBoxUrlCapture.Visible = true;
            pictureBoxSavepath.Visible = true;
            labelSavePath.Visible = true;
            label5.Visible = true;
        }
    }
}
