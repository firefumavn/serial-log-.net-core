namespace ApplicationCore.Interfaces
{
    public interface ILoggerAdapter
    {
        /// <summary>
        /// WriteMethodInfo
        /// </summary>
        /// <param name="parameters"></param>
        void WriteMethodInfo(params object[] parameters);

        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="messageTemplate"></param>
        void Debug(string messageTemplate);

        /// <summary>
        /// Debug
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        void Debug<T>(string messageTemplate, T propertyValue);

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="messageTemplate"></param>
        void Error(string messageTemplate);

        /// <summary>
        /// Error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        void Error<T>(string messageTemplate, T propertyValue);

        /// <summary>
        /// Information
        /// </summary>
        /// <param name="messageTemplate"></param>
        void Information(string messageTemplate);

        /// <summary>
        /// Information
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        void Information<T>(string messageTemplate, T propertyValue);

        /// <summary>
        /// Warning
        /// </summary>
        /// <param name="messageTemplate"></param>
        void Warning(string messageTemplate);

        /// <summary>
        /// Warning
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        void Warning<T>(string messageTemplate, T propertyValue);

        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="messageTemplate"></param>
        void Fatal(string messageTemplate);

        /// <summary>
        /// Fatal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValue"></param>
        void Fatal<T>(string messageTemplate, T propertyValue);
    }
}
