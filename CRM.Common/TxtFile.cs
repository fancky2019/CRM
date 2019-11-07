using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
   public class TxtFile
    {



        public static List<string> ReadTxtFile(string fllPath)
        {
            List<string> content = new List<string>();
            if (File.Exists(fllPath))
            {
                using (StreamReader sr = new StreamReader(new FileStream(fllPath, FileMode.Open)))
                {
                    try
                    {
                        while (!sr.EndOfStream)
                        {
                            // string line = sr.ReadLine().Trim();
                            content.Add(sr.ReadLine().Trim());
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            return content;
        }


        public static void SaveTxtFile(string fllPath, List<string> content, FileMode fileMode = FileMode.Create)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(fllPath, fileMode, FileAccess.Write), System.Text.Encoding.UTF8))
            {
                foreach (string str in content)
                {
                    sw.WriteLine(str);
                }
            }
        }
    }
}
