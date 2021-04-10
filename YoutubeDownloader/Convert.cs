using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaToolkit;
using MediaToolkit.Model;

namespace YoutubeDownloader
{
    class Convert
    {
        //packete manager ->MediToolkit

        public bool Mp4ToMp3( string Path , string VideFullName  )
        {
            try
            {
                var inputFile = new MediaFile { Filename = Path + VideFullName };
                var outputFile = new MediaFile { Filename = $"{Path + VideFullName.Replace(".mp4" ,"")}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }
                return true;
            }
            catch (Exception)
            {
                //return false;
                throw;
            }
        }




    }
}
