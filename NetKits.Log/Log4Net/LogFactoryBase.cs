using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NetKits.Log
{
    /// <summary> LogFactory Base class
    /// </summary>
    public abstract class LogFactoryBase : ILogFactory
    {
        /// <summary> Gets the config file file path.
        /// </summary>
        protected string ConfigFile { get; private set; }

        /// <summary> Initializes a new instance of the <see cref="LogFactoryBase"/> class.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        protected LogFactoryBase(string configFile)
        {
            if (Path.IsPathRooted(configFile))
            {
                if (File.Exists(configFile))
                    ConfigFile = configFile;
                else
                    ConfigFile = string.Empty;
            }
            else
            {
                string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile);
                if (File.Exists(FilePath))
                {
                    ConfigFile = FilePath;
                    return;
                }
                FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config\\" + configFile);
                if (File.Exists(FilePath))
                {
                    ConfigFile = FilePath;
                    return;
                }
                ConfigFile = string.Empty;
            }
        }

        /// <summary> Gets the log by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public abstract ILog GetLog(string name);

        /// <summary> Gets the log by type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract ILog GetLog(Type type);
    }
}
