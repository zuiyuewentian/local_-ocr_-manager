using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI.Common
{
    public class DirectoryHelper
    {
        /// <summary>
        /// 清空文件夹文件
        /// </summary>
        public static void ClearFiles(string tempPath)
        {
            try
            {
                if (Directory.Exists(tempPath))
                {
                    foreach (string strFile in Directory.GetFiles(tempPath))
                    {
                        File.Delete(strFile);
                    }
                    foreach (string strFile in Directory.GetDirectories(tempPath))
                    {
                        ClearFiles(strFile);
                        Directory.Delete(strFile);
                    }

                }
                else
                {
                    Directory.CreateDirectory(tempPath);
                }
            }
            catch (Exception)
            {
            }
         
        }
    }
}
