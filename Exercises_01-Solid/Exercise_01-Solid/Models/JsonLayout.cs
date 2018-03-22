using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Models
{
    public class JsonLayout : ILayout // гърми формат
    {
        const string DateFormat = "HH:mm:ss dd/M/yyyy";
        const string Layout = "{ DateTime: {0}, ErrorLevel: {1}, Message {2} }";

        
        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat,
                CultureInfo.InvariantCulture);
            string formatedError = string.Format(Layout, dateString, error.Level.ToString(), error.Message);
            return formatedError;
        }
    }
}