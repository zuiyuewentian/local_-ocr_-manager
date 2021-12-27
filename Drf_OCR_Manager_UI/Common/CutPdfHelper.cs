using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI.Common
{
    public class CutPdfHelper
    {
        public delegate void ChangeDelegate(int pageIndex, int sumCount,string imgName);

        public static event ChangeDelegate ChangeEvent;


        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);

        private static bool Is64Bit()
        {
            bool retVal;
            IsWow64Process(Process.GetCurrentProcess().Handle, out retVal);
            return retVal;
        }

        public enum Definition
        {
            One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10
        }

        public static int GetPdfPagesCount(string pdfPath)
        {
            PdfReader pdfReader = new PdfReader(pdfPath);
            int count = pdfReader.NumberOfPages;
            pdfReader.Close();
            return count;
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="imageOutputPath">图片输出路径</param>
        /// <param name="imageName">生成图片的名字</param>
        public static void ConvertPDF2Image(string pdfInputPath, string imageOutputPath,
            string imageName)
        {
            int pageCount = GetPdfPagesCount(pdfInputPath);
            if (pageCount <= 0)
                return;
            // ConvertPDF2Image64(pdfInputPath, imageOutputPath, imageName, 0, pageCount, ImageFormat.Jpeg, Definition.One);
            int startPageNum = 0;
            int endPageNum = pageCount;

            //if (Is64Bit())
            //{
            ConvertPDF2Image64(pdfInputPath, imageOutputPath, imageName, startPageNum, endPageNum, ImageFormat.Png, Definition.One);
            //}
            //else
            //{
            //    ConvertPDF2Image32(pdfInputPath, imageOutputPath, imageName, startPageNum, endPageNum, ImageFormat.Png, Definition.One);
            //}
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="imageOutputPath">图片输出路径</param>
        /// <param name="imageName">生成图片的名字</param>
        /// <param name="startPageNum">从PDF文档的第几页开始转换</param>
        /// <param name="endPageNum">从PDF文档的第几页开始停止转换</param>
        /// <param name="imageFormat">设置所需图片格式</param>
        /// <param name="definition">设置图片的清晰度，数字越大越清晰</param>
        public static void ConvertPDF2Image64(string pdfInputPath, string imageOutputPath,
        string imageName, int startPageNum, int endPageNum, ImageFormat imageFormat, Definition definition)
        {

            PDFLibNet64.PDFWrapper pdfWrapper = new PDFLibNet64.PDFWrapper();

            pdfWrapper.LoadPDF(pdfInputPath);

            if (!System.IO.Directory.Exists(imageOutputPath))
            {
                Directory.CreateDirectory(imageOutputPath);
            }

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > pdfWrapper.PageCount)
            {
                endPageNum = pdfWrapper.PageCount;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }

            // start to convert each page
            for (int i = startPageNum; i <= endPageNum; i++)
            {
                string temp = i.ToString().PadLeft(5, '0') + ".jpg";
                pdfWrapper.ExportJpg(imageOutputPath + temp, i, i, 180, 80);//这里可以设置输出图片的页数、大小和图片质量
                if (pdfWrapper.IsJpgBusy) { System.Threading.Thread.Sleep(100); }
                
                ChangeEvent?.Invoke(i, endPageNum, temp);
            }

            pdfWrapper.Dispose();
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="imageOutputPath">图片输出路径</param>
        /// <param name="imageName">生成图片的名字</param>
        /// <param name="startPageNum">从PDF文档的第几页开始转换</param>
        /// <param name="endPageNum">从PDF文档的第几页开始停止转换</param>
        /// <param name="imageFormat">设置所需图片格式</param>
        /// <param name="definition">设置图片的清晰度，数字越大越清晰</param>
        public static void ConvertPDF2Image32(string pdfInputPath, string imageOutputPath,
        string imageName, int startPageNum, int endPageNum, ImageFormat imageFormat, Definition definition)
        {

            PDFLibNet32.PDFWrapper pdfWrapper = new PDFLibNet32.PDFWrapper();

            pdfWrapper.LoadPDF(pdfInputPath);

            if (!Directory.Exists(imageOutputPath))
            {
                Directory.CreateDirectory(imageOutputPath);
            }

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > pdfWrapper.PageCount)
            {
                endPageNum = pdfWrapper.PageCount;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }


            // start to convert each page
            for (int i = startPageNum; i <= endPageNum; i++)
            {
                string temp = i.ToString().PadLeft(5, '0') + ".jpg";
                pdfWrapper.ExportJpg(imageOutputPath + temp, i, i, 180, 80);//这里可以设置输出图片的页数、大小和图片质量
                if (pdfWrapper.IsJpgBusy) { System.Threading.Thread.Sleep(100); }
                ChangeEvent?.Invoke(i, endPageNum,temp);
            }

            pdfWrapper.Dispose();
            GC.Collect();
        }
    }
}
