using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace Potato.Classes
{
    public class DebugUtils
    {
        public static void PrintInConsole(String text) {
            System.Diagnostics.Debug.WriteLine(text);
        }

        public static void PrintXmlToConsole(XmlDocument xmlDoc) {
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            {
                xmlDoc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                System.Diagnostics.Debug.WriteLine(stringWriter.GetStringBuilder().ToString());
            }
        }
    }
}