using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjConfig
{
    // INI文件操作类
    class IniHelper
    {
        string IniFilePath;  // ini配置文件路径

        #region DLL
        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(byte[] section, byte[] key, byte[] val, string filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(byte[] section, byte[] key, byte[] def, byte[] retVal, int size, string filePath);
        #endregion

        /// <summary>
        /// ctor
        /// </summary>
        public IniHelper(string path)
        {
            this.IniFilePath = path;
        }


        private byte[] getBytes(string s, string encodingName)
        {
            return null == s ? null : Encoding.GetEncoding(encodingName).GetBytes(s);
        }

        public string ReadString(string section, string key, string encodingName = "utf-8", int size = 1024)
        {
            byte[] buffer = new byte[size];
            int count = GetPrivateProfileString(getBytes(section, encodingName),
                                                getBytes(key, encodingName),
                                                getBytes("", encodingName),
                                                buffer,
                                                size,
                                                IniFilePath);

            return Encoding.GetEncoding(encodingName).GetString(buffer, 0, count).Trim();
        }

        public bool WriteString(string section, string key, string value, string encodingName = "utf-8")
        {
            return WritePrivateProfileString(getBytes(section, encodingName),
                                             getBytes(key, encodingName),
                                             getBytes(value, encodingName),
                                             IniFilePath);
        }
    }
}