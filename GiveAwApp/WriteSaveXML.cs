using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace GiveAwApp
{
    class WriteSaveXML
    {

        public void saveXml(List<GiveAway> list)
        {
            //Write List<T> to XML file
            string output = "GiveAwayData.xml";
            List<GiveAway> listGive = list.Distinct().ToList();

            XmlSerializer serialiser = new XmlSerializer(typeof(List<GiveAway>));
            TextWriter FileStream = new StreamWriter(output);
            serialiser.Serialize(FileStream, listGive);
            FileStream.Close();
        }

        public List<GiveAway> readXml()
        {
            //Write List<T> to XML file
            string path = "GiveAwayData.xml";
            List<GiveAway> listGive = new List<GiveAway>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<GiveAway>));

            StreamReader reader = new StreamReader(path);
            listGive = (List<GiveAway>)serializer.Deserialize(reader);
            reader.Close();

            return listGive;     
        }
    }

}
