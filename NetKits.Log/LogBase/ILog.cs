using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetKits.Log
{
    /// <summary> 日志对象接口
    /// </summary>
    public interface ILog
    {
        /// <summary> 获取一个值，该值指示该实例是否已调试启用。
        /// </summary>
        /// <value>
        /// 	<c>true</c> 启用 调试日志
        /// 	<c>false</c>.
        /// </value>
        bool IsDebugEnabled { get; }

        /// <summary> 获取一个值，该值指示该实例是否启用错误。
        /// </summary>
        /// <value>
        /// 	<c>true</c>启用 错误日志
        /// 	<c>false</c>.
        /// </value>
        bool IsErrorEnabled { get; }

        /// <summary> 获取一个值，该值指示该实例是否是致命的
        /// </summary>
        /// <value>
        /// 	<c>true</c> 启用 致命错误日志
        /// 	<c>false</c>.
        /// </value>
        bool IsFatalEnabled { get; }

        /// <summary> 获取一个值，该值指示该实例是否已启用信息。
        /// </summary>
        /// <value>
        /// 	<c>true</c> 启用信息日志
        /// 	<c>false</c>.
        /// </value>
        bool IsInfoEnabled { get; }

        /// <summary> 获取一个值，该值指示该实例是否为启用警告。
        /// </summary>
        /// <value>
        /// 	<c>true</c> 启用警告日志
        /// 	<c>false</c>
        /// </value>
        bool IsWarnEnabled { get; }

        /// <summary> 记录调试信息 
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(object message);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Debug(object message, Exception exception);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        void DebugFormat(string format, object arg0);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void DebugFormat(string format, params object[] args);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void DebugFormat(IFormatProvider provider, string format, params object[] args);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        void DebugFormat(string format, object arg0, object arg1);

        /// <summary> 记录调试信息
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        void DebugFormat(string format, object arg0, object arg1, object arg2);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(object message);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Error(object message, Exception exception);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        void ErrorFormat(string format, object arg0);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void ErrorFormat(string format, params object[] args);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void ErrorFormat(IFormatProvider provider, string format, params object[] args);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        void ErrorFormat(string format, object arg0, object arg1);

        /// <summary> 记录错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        void ErrorFormat(string format, object arg0, object arg1, object arg2);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="message">The message.</param>
        void Fatal(object message);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Fatal(object message, Exception exception);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        void FatalFormat(string format, object arg0);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void FatalFormat(string format, params object[] args);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void FatalFormat(IFormatProvider provider, string format, params object[] args);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        void FatalFormat(string format, object arg0, object arg1);

        /// <summary> 记录致命错误信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        void FatalFormat(string format, object arg0, object arg1, object arg2);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(object message);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Info(object message, Exception exception);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        void InfoFormat(string format, object arg0);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void InfoFormat(string format, params object[] args);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void InfoFormat(IFormatProvider provider, string format, params object[] args);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        void InfoFormat(string format, object arg0, object arg1);

        /// <summary> 记录信息消息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        void InfoFormat(string format, object arg0, object arg1, object arg2);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="message">The message.</param>
        void Warn(object message);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Warn(object message, Exception exception);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        void WarnFormat(string format, object arg0);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void WarnFormat(string format, params object[] args);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        void WarnFormat(IFormatProvider provider, string format, params object[] args);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        void WarnFormat(string format, object arg0, object arg1);

        /// <summary> 记录警告信息。
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        void WarnFormat(string format, object arg0, object arg1, object arg2);
    }
}
