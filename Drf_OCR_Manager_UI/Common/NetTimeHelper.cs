using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI.Common
{
    public class NetTimeHelper
    {
        public static string GetNetDateTime()
        {
            WebRequest request = null;
            WebResponse response = null;
            WebHeaderCollection headerCollection = null;
            string datetime = string.Empty;
            try
            {
                request = WebRequest.Create("https://www.baidu.com");
                request.Timeout = 3000;
                request.Credentials = CredentialCache.DefaultCredentials;
                response = (WebResponse)request.GetResponse();
                headerCollection = response.Headers;
                foreach (var h in headerCollection.AllKeys)
                { if (h == "Date") { datetime = headerCollection[h]; } }
                return datetime;
            }
            catch (Exception) { return datetime; }
            finally
            {
                if (request != null)
                { request.Abort(); }
                if (response != null)
                { response.Close(); }
                if (headerCollection != null)
                { headerCollection.Clear(); }
            }
        }

        /// <summary>
        /// 获取网络时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetTime()
        {
            try
            {
                string dt = GetNetDateTime();
                return Convert.ToDateTime(dt);
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--GetTime");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");
                return DateTime.Now;
            }
          
        }
    }
}
