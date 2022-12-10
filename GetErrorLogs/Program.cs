using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetErrorLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = ConfigurationManager.AppSettings["ErrorLogFilePath"];
                var fileData= InternalReadAllText(filePath, Encoding.UTF8);
                Console.WriteLine("File data : \n " + fileData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(true);
        }
        public static string InternalReadAllText(string path, Encoding encoding)
        {
            string result;
            using (StreamReader streamReader = new StreamReader(path, encoding))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
        
    }
}
