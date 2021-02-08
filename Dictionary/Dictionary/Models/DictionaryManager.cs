using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Dictionary.Models
{
    class DictionaryManager
    {
        #region Properties
        DictionaryItem items { get; set; }
        private string filePath = "../File/dictionary.xml";

        public DictionaryManager()
        {
            items = (DictionaryItem)DeserializeFromXML(filePath);
        }
        #endregion

        #region methods
        public void LoadDataToCombo(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }

        public void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            sr.Serialize(fs, data);
            fs.Close();
        }

        public void Serialize()
        {
            SerializeToXML(items, filePath);
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            object obj = sr.Deserialize(fs);
            fs.Close();
            return obj;
        }
        #endregion
    }
}
