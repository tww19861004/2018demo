using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;


namespace ConsoleApplication2
{
    class Program
    {




        static void Main(string[] args)
        {
            string data = "ha5b3c78992128b61952";  //要加密的数据
            string encodeStr = "";   //加密后文本
            string decodeStr = "";   //解密后文本


            Console.WriteLine("原文本：{0}", data);
            encodeStr = DESEnCode(data, DES_Key);
            Console.WriteLine("加密后文本：{0}", encodeStr);
            decodeStr = DESDeCode(encodeStr, DES_Key);
            Console.WriteLine("解密后文本：{0}", decodeStr);
            Console.Read();
        }


        //cookies加密密钥   
        public static string DES_Key = "#!12^0#@";


        #region DESEnCode DES加密
        public static string DESEnCode(string pToEncrypt, string sKey)
        {
            // pToEncrypt = HttpContext.Current.Server.UrlEncode(pToEncrypt);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.GetEncoding("UTF-8").GetBytes(pToEncrypt);




            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);


            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();


            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }
        #endregion


        #region DESDeCode DES解密
        public static string DESDeCode(string pToDecrypt, string sKey)
        {
            //    HttpContext.Current.Response.Write(pToDecrypt + "<br>" + sKey);   
            //    HttpContext.Current.Response.End();   
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();


            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                string aa = pToDecrypt.Substring(x * 2, 2).ToString();
                int i = (Convert.ToInt32(aa, 16));
                inputByteArray[x] = (byte)i;
            }


            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();


            StringBuilder ret = new StringBuilder();
            return System.Text.Encoding.Default.GetString(ms.ToArray());
            // return null;
            //HttpContext.Current.Server.UrlDecode(System.Text.Encoding.Default.GetString(ms.ToArray()));
        }

        #endregion


    }
}