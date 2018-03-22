using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger.Models
{
    class LogFile : ILogFile
    {

        const string DefaultPath = "./data/";

        public LogFile(string fileName)
        {
            this.Path = DefaultPath + fileName;
            InitializeFile();
            this.Size = 0;
        }

        private void InitializeFile()
        {
            Directory.CreateDirectory(DefaultPath);
            File.AppendAllText(this.Path, "");
        }

        public string Path { get; }

        public int Size { get; private set; }

        public void WriteToFile(string errorlog)
        {
            File.AppendAllText(this.Path, errorlog + Environment.NewLine);

            int addedSize = 0;

            for (int i = 0; i < errorlog.Length; i++)
            {
                addedSize += errorlog[i];
            }

            this.Size += addedSize;
        }
    }
}
