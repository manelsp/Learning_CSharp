using System;
using System.IO;
using System.Net;
using System.Text;

namespace Examples.System.Net
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            string inputString;
            char response1;
            string response2;
            string response3;
            
            Console.Write("Quieres bajar un archivo de la base de datos? y/n \n");
            inputString = Console.ReadLine();
            response1 = Convert.ToChar(inputString);
            if (response1 == 'y')
            {
                Console.Write("Que archivo quieres bajar? \n");
                inputString = Console.ReadLine();
                response2 = inputString;
                Console.Write("Con que nombre lo quieres bajar? Recuerda poner la misma extensión\n");
                inputString = Console.ReadLine();
                response3 = inputString;
                String LocalDestinationPath = response3;
                Console.Write("Bajando \n");
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://172.17.6.0/prueba/"+response2);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("g05", "12345aA");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse(); 
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                using (FileStream writer = new FileStream(LocalDestinationPath, FileMode.Create))
                {

                    long length = response.ContentLength;
                    int bufferSize = 2048;
                    int readCount;
                    byte[] buffer = new byte[2048];

                    readCount = responseStream.Read(buffer, 0, bufferSize);
                    while (readCount > 0)
                    {
                        writer.Write(buffer, 0, readCount);
                        readCount = responseStream.Read(buffer, 0, bufferSize);
                    }
                }
                Console.WriteLine("Descarga completada, status {0}", response.StatusDescription);
                reader.Close();
                response.Close();
               
            }
            else {
                Console.WriteLine("Bye!");
                 }
        }
    
    }
    
}
