using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;

namespace NetKits.Log
{
    /// <summary> Log4NetLog的日志工厂
    /// </summary>
    public class Log4NetLogFactory : LogFactoryBase
    {
        /// <summary> 初始化一个<see cref="Log4NetLogFactory"/>日志工厂,默认查找软件根目录下NetKitsLog.config和Config子目录下的NetKitsLog.config
        /// </summary>
        /// <param name="enableNoFileError">指示没有找到文件时是否抛出异常 如果为<c>True</c>时则未找到文件会抛出异常</param>
        /// <exception cref="IOException">指定的文件不存在时,如果enableNoFileError参数设置为<c>True</c>则抛出IO异常</exception>
        public Log4NetLogFactory(bool enableNoFileError = true)
            : this("NetKitsLog.config", enableNoFileError)
        {
        }

        /// <summary> 初始化一个<see cref="Log4NetLogFactory"/>日志工厂,查找软件根目录下的<c>log4netConfig</c>和config子目录下的<c>log4netConfig</c>
        /// </summary>
        /// <param name="log4netConfig">指示自定义名称的配置文件名称,需要带上后缀</param>
        /// <param name="enableNoFileError">指示没有找到文件时是否抛出异常 如果为<c>True</c>时则未找到文件会抛出异常</param>
        /// <exception cref="IOException">指定的文件不存在时,如果enableNoFileError参数设置为<c>True</c>则抛出IO异常</exception>
        public Log4NetLogFactory(string log4netConfig, bool enableNoFileError = true)
            : base(log4netConfig)
        {
            if (string.IsNullOrEmpty(ConfigFile))
            {
                if (enableNoFileError)
                    throw new IOException(string.Format("指定配置文件\"{0}\"不存在,如果想忽略可将enableNoFileError设置为False", log4netConfig));
                else
                    BasicConfigurator.Configure(new ConsoleAppender { Layout = new PatternLayout() });
            }
            else
            {
                log4net.Config.XmlConfigurator.Configure(new FileInfo(ConfigFile));
            }

            #region -----另外一种模式 详细可查看 SuperSocket
            //Disable Performance logger 禁用性能记录器
            //var xmlDoc = new XmlDocument();
            //xmlDoc.Load(ConfigFile);
            //var docElement = xmlDoc.DocumentElement;
            //var perfLogNode = docElement.SelectSingleNode("logger[@name='Performance']");
            //if (perfLogNode != null)
            //    docElement.RemoveChild(perfLogNode);
            //log4net.Config.XmlConfigurator.Configure(docElement);

            #endregion
        }

        /// <summary> 根据名称获取一个日志对象.
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public override ILog GetLog(string name)
        {
            return new Log4NetLog(LogManager.GetLogger(name));
        }

        /// <summary> 根据类型获取一个日志对象.
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public override ILog GetLog(Type type)
        {
            return new Log4NetLog(LogManager.GetLogger(type));
        }
    }
}
