using Drf_OCR_Manager_UI.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Drf_OCR_Manager_UI.Common
{
    public class CheckUserHelper
    {
        /// <summary>
        /// 验证uuid
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static UserInfoModel CheckUser(string data)
        {
            try
            {
                string[] datalist = data.Split('-');
                UserInfoModel user = new UserInfoModel();
                string uuid = GetComputerUUID.GetUUID();
                string[] uuids = uuid.Split('-');
                int len = uuids.Length;

                string key = uuids[0] + datalist[datalist.Length - 1] + uuids[len - 1] + uuids[len - 1] + uuids[0];

                user.s_uuid = AESHelper.Decrypt(datalist[1], key);
                user.s_version = AESHelper.Decrypt(datalist[2], key);
                user.s_form = AESHelper.Decrypt(datalist[3], key);
                user.s_expire = AESHelper.Decrypt(datalist[4], key);
                user.s_create = AESHelper.Decrypt(datalist[5], key);
                user.m_data = data;
                return user;
            }
            catch (Exception ex)
            {
                log4netHelper.Error("---报错方法--CheckUser");
                log4netHelper.Error(ex.Message);
                log4netHelper.Error(ex.StackTrace);
                log4netHelper.Error(ex.ToString());
                log4netHelper.Error("---end---");

                return null;
            }
        }
    }
}