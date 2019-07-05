using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    /// <summary>
    /// 安装压缩程序包 SharpZipLib 程序包
    /// </summary>
    public class Zip
    {
        public static void ZipLog()
        {
            try
            {
                //string sendMsgRootPath = @"D:\ZProject\connamara-quickfixn-2d35bed-TT\TTMarketAdapter\bin\Debug\SendMsg";
                string sendMsgRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"SendMsg");
                //获取所有的.txt文件，文件夹含有压缩的.zip文件
                List<string> fileList = Directory.GetFiles(sendMsgRootPath, "*.txt", SearchOption.AllDirectories).ToList();
                foreach (var p in fileList)
                {
                    string fileName = Path.GetFileNameWithoutExtension(p);
                    if (int.TryParse(fileName, out int day))//防止文件名称不是数字
                    {
                        //不压缩当天的日记文件
                        if (day == DateTime.Now.Day)
                        {
                            continue;
                        }
                        Zip(p);
                    }
                    else//文件名称不是数字的直接压缩
                    {
                        Zip(p);
                    }

                }
                //压缩
                void Zip(string fileFullPath)
                {
                    if (!File.Exists(fileFullPath))
                    {

                        return;
                    }
                    var ss = Path.GetFullPath(fileFullPath);
                    string zipFilePath = fileFullPath.Replace(Path.GetExtension(fileFullPath), ".zip");
                    try
                    {
                        //安装压缩程序包 SharpZipLib 程序包
                        //string[] filenames = Directory.GetFiles(path);
                        using (ZipOutputStream s = new ZipOutputStream(File.Create(zipFilePath)))
                        {
                            // 压缩级别 0-9
                            s.SetLevel(9);
                            //s.Password = "123"; //Zip压缩文件密码
                            byte[] buffer = new byte[4096]; //缓冲区大小
                            ZipEntry entry = new ZipEntry(Path.GetFileName(fileFullPath));
                            entry.DateTime = DateTime.Now;
                            s.PutNextEntry(entry);
                            using (FileStream fs = File.OpenRead(fileFullPath))
                            {
                                int sourceBytes;
                                do
                                {
                                    sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                    s.Write(buffer, 0, sourceBytes);
                                } while (sourceBytes > 0);
                            }
                            s.Finish();
                            s.Close();
                        }
                        //压缩成功后删除.txt文件
                        File.Delete(fileFullPath);
                    }
                    catch (Exception ex)
                    {
                        Log.Error<Zip>(ex.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error<Zip>(ex.Message);
            }
        }
    }
}
