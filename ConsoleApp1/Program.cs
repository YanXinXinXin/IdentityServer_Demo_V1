using PinRui.EDiner2.CanquSDK;
using PinRui.EDiner2.CanquSDK.WMSService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SDKConfig.APIUrl = "http://192.168.2.206:8989/SDK/";
            SDKConfig.Key = "123456";
            SDKConfig.Secret = "123456";
            var ssdf = EncryptMD5("888888");
            var user = CurrentUserFactory.Login("tstuser2", EncryptMD5("888888"), "192.168.2.78"); //登录
            Console.WriteLine(user.LoginKey);

        }
        private static string EncryptMD5(string s)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(s))).Replace("-", "").ToLower();
        }
    }
}
