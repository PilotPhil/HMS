using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MarineControl.HMS.Cfg
{
    class ConfigHelper
    {
        /// <summary>
        /// 构造
        /// </summary>
        public ConfigHelper() { }

        /// <summary>
        /// 读取key对于value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReadSetting(string seletedNode,string key)
        {
            XmlDocument doc = loadConfigDocument();

            XmlNode node = doc.SelectSingleNode(seletedNode);//"//appSettings"

            if (node == null)
                throw new InvalidOperationException("appSettings section not found in config file.");

            try
            {
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    return elem.GetAttribute("value");
                }
            }
            catch
            {
                throw;
            }

            return "";
        }

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">key对于的value</param>
        public static void WriteSetting(string seletedNode,string key, string value)
        {
            XmlDocument doc = loadConfigDocument();

            XmlNode node = doc.SelectSingleNode(seletedNode);

            if (node == null)
                throw new InvalidOperationException("appSettings section not found in config file.");

            try
            {
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    elem.SetAttribute("value", value);
                }
                else
                {
                    elem = doc.CreateElement("add");
                    elem.SetAttribute("key", key);
                    elem.SetAttribute("value", value);
                    node.AppendChild(elem);
                }
                doc.Save(getConfigFilePath());
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 移除节
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveSetting(string key)
        {
            XmlDocument doc = loadConfigDocument();

            XmlNode node = doc.SelectSingleNode("//appSettings");

            try
            {
                if (node == null)
                    throw new InvalidOperationException("appSettings section not found in config file.");
                else
                {
                    node.RemoveChild(node.SelectSingleNode(string.Format("//add[@key='{0}']", key)));
                    doc.Save(getConfigFilePath());
                }
            }
            catch (NullReferenceException e)
            {
                throw new Exception(string.Format("The key {0} does not exist.", key), e);
            }
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <returns></returns>
        private static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(getConfigFilePath());//加载获取到的默认App.config配置文件
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        /// <summary>
        /// 获取配置文件路径
        /// </summary>
        /// <returns></returns>
        private static string getConfigFilePath()
        {
            return Assembly.GetExecutingAssembly().Location + ".config";
        }
    }
}