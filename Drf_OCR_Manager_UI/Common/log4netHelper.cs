using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drf_OCR_Manager_UI
{
    public class log4netHelper
    {
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Error(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Error");
            log.Error(message);
        }

        /// <summary>
        /// info日志
        /// </summary>
        /// <param name="message">错误日志</param>
        public static void Info(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Info");
            log.Info(message);
        }
    }
}
