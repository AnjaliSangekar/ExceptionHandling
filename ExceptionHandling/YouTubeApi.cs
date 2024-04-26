using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {

            try
            {
                // Access youtube web service
                // read the data
                // carete a list of video objects

                throw new Exception("Oops some low level video exception");

            }
            catch (Exception e)
            {
                throw new YouTubeException("Could not fetch video", e);
            }

            return new List<Video>();

        }

    }
}
