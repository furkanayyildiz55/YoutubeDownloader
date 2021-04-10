using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using VideoLibrary;
using System.IO;
using System.Drawing;
using System.Net;

namespace YoutubeDownloader
{
    class Dowloader
    {
        //packete manager ->YoutubeExplode and VideLibrary

        public TimeSpan Duration { get; set; }
        public string VideoName { get; set; }
        public int Audio_Bitrate { get; set; }
        public int Resulation { get; set; }

        private Bitmap ImageBitmap;
        private string Url;

        public Dowloader(string VideoUrl)
        {
            Url = VideoUrl;
            GetInfo();
        }



        private void GetInfo()
        {
            try
            {
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(Url);

                VideoName = vid.FullName;
                Audio_Bitrate = vid.AudioBitrate;
                Resulation = vid.Resolution;
            }
            catch (Exception)
            {

            }

        }


        public bool VideoDownload(string path)
        {
            try
            {
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(Url);

                File.WriteAllBytes(path + vid.FullName, vid.GetBytes());
                GC.Collect();
                return true;
            }
            catch
            {
                return false;
                throw;
            }

        }


        public Bitmap GetImageBitmap()
        {
            return ImageBitmap;
        }

        public void GetImage()
        {
            try
            {
                string ImageUrl = "https://img.youtube.com/vi/" + GetVideoIdentifier(Url) +"/default.jpg";
               
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(ImageUrl);
                ImageBitmap = new Bitmap(stream);
                stream.Flush();
                stream.Close();
            }
            catch
            {
                throw;
            }
        }

        private string GetVideoIdentifier(string url)
        {
            try
            {
                string identifier = url.Split(new char[] { '=' })[1];

                try
                {
                    if (identifier.Contains("&"))
                    {
                        identifier = identifier.Split(new char[] { '&' })[0];
                    }
                }
                catch (Exception) { }

                return identifier;
            }
            catch (Exception)
            {
                return "";
            }

        }




    }
}
