using Logger.Models.Contracts;

namespace Logger.Models.Factories
{
    internal class FileAppender : IAppender
    {
        private ILogFile logFile;

        public FileAppender(ILayout layout, ErrorLevel errorLevel, ILogFile logFile)
        {
            this.Layout = layout;
            this.Level = errorLevel;
            this.logFile = logFile;
            this.MessagessAppended = 0;
        }

        public ILayout Layout { get; }

        public ErrorLevel Level { get; }

        public int MessagessAppended { get; private set; }

        public void Append(IError error)
        {
            string formatedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formatedError);
            this.MessagessAppended++;

        }

        public override string ToString()
        {
            string appenderType = this.GetType().Name;
            string layoutType = this.Layout.GetType().Name;
            string level = this.Level.ToString();

            string result = $"Appender type: {appenderType}, Layout type: {layoutType}, Report level: {level}, Message append: {this.MessagessAppended}, File size: {this.logFile.Size}";

            return result;
        }
    }
}