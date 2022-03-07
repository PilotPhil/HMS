using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConfig
{
    public interface IProjConfig
    {
        /// <summary>
        /// 设置文件路径
        /// </summary>
        /// <param name="path"></param>
        void SetProjFilePath(string filePath);

        /// <summary>
        /// 将目标模型序列化写入json文件
        /// </summary>
        /// <param name="objModel"></param>
        void Save(string SectionName, object model);

        /// <summary>
        /// 从json文件读取某类型model
        /// </summary>
        T Init<T>(string SectionName);

    }
}
