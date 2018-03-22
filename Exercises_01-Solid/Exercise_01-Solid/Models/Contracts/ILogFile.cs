using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models
{
    public interface ILogFile
    {
        string Path { get; }

        int Size { get; }

        void WriteToFile(string errorlog);
    }
}
