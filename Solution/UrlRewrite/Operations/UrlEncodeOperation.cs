﻿using System.IO;
using System.Web;
using System.Xml.Linq;
using UrlRewrite.Interfaces;

namespace UrlRewrite.Operations
{
    public class UrlEncodeOperation: IOperation
    {
        public string Execute(string value)
        {
            return ReferenceEquals(value, null) ? string.Empty : HttpUtility.UrlEncode(value);
        }

        public void Initialize(XElement configuration)
        {
        }

        public string ToString(IRequestInfo requestInfo)
        {
            return "UrlEncode()";
        }

        public override string ToString()
        {
            return "UrlEncode()";
        }

        public void Describe(TextWriter writer, string indent, string indentText)
        {
            writer.Write(indent);
            writer.WriteLine("url encode");
        }
    }
}
