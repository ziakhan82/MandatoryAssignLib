using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MandatoryAssignLib
{
    public  class Configuration
    {

        public static int MinWorld { get; set; }
        public static int MaxWorld { get; set; }

        public static void ReadConfiguration()
        {

            string xmldoc = "configuration.xml";

            string path = Environment.GetEnvironmentVariable("war");

            string fullpath = Path.Combine(path, xmldoc);

            XmlDocument configdoc = new XmlDocument();
            configdoc.Load(fullpath);

            XmlNode WorldMininumSize = configdoc.DocumentElement.SelectSingleNode("worldsizeminimum");
            if (WorldMininumSize != null)
            {
                string minwolrd = WorldMininumSize.InnerText.Trim();

                MinWorld = Convert.ToInt32(minwolrd);




                XmlNode worldMaximum = configdoc.DocumentElement.SelectSingleNode("worldmaximum");
                if (worldMaximum != null)
                {
                    string maxwolrd = worldMaximum.InnerText.Trim();

                    MaxWorld = Convert.ToInt32(maxwolrd);


                }


            }


        }
    }
}
