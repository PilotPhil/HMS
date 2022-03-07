using Newtonsoft.Json;
using System;
using System.IO;

namespace ProjConfig
{
    public class JsonProjConfig:IProjConfig
    {
        //json文件路径
        private IniHelper iniHelper;
        private readonly string DefaultSectionName="ProjectParams";

        /// <summary>
        /// ctor
        /// </summary>
        public JsonProjConfig()
        {

        }

        /// <summary>
        /// 设置路径
        /// </summary>
        /// <param name="filePath"></param>
        public void SetProjFilePath(string filePath)
        {
            this.iniHelper = new IniHelper(filePath);
        }

        /// <summary>
        /// 序列化并写入
        /// </summary>
        /// <param name="model"></param>
        public void Save(string Key, object model)
        {
            try
            {
                string JsonData = JsonConvert.SerializeObject(model);
                iniHelper.WriteString(DefaultSectionName, Key, JsonData);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 读出并反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Init<T>(string Key)
        {
            try
            {
                string JsonData = iniHelper.ReadString(DefaultSectionName, Key);
                return JsonConvert.DeserializeObject<T>(JsonData);//反序列化
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
