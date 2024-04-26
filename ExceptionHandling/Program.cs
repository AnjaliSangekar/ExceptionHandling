using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //    Console.WriteLine(result);

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Exception is occured");
            //}


            //try
            //{
            //    using (var streamReader = new StreamReader(@"c:\file.zip")) 
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Sorry an unexpected error");
            //}



            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
