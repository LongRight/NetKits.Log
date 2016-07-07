using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetKits.Log
{
    /// <summary> 日志工厂接口
    /// </summary>
    public interface ILogFactory
    {
        /// <summary> 根据名称获取一个日志对象.
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        ILog GetLog(string name);

        /// <summary> 根据类型获取一个日志对象.
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        ILog GetLog(Type type);
    }
}
