using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace _13.DownloadFile
{
    //Write a program that downloads a file from Internet by given URL

    class FileDownloading
    {
        static void Main(string[] args)
        {
            //1.We add System.Net;
            //2. try-catch construction
            //3.Use Uri to target link for download
            //4.Enter file extension
            //5.We use WebClient and methd .DownloadFileAsync

            string uri = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileExtension = Path.GetExtension(uri);
            string name = "nekva";
           
            using (WebClient myClient = new WebClient())
            {
                try
                {
                    myClient.DownloadFile(uri, name + fileExtension);
                    Console.WriteLine("Process succeeded");
                }

                catch (WebException)
                {
                    Console.WriteLine("Invalid address.");
                }
            }

        }
    }
}
