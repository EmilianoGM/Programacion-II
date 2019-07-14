using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades.SP
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Mazana";
            }

        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Manzana(string color, double peso, string provinciaDeOrigen) : base(color, peso)
        {
            this._provinciaOrigen = provinciaDeOrigen;
        }

        public override string ToString()
        {
            return base.FrutaToString() + " - " + this._provinciaOrigen + " - Carozo: " + this.TieneCarozo.ToString();
        }

        public bool Xml(string path)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ruta += "\\" + path;
            if (File.Exists(ruta))
            {
                StreamWriter streamWriter = new StreamWriter(ruta);
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                    xmlSerializer.Serialize(streamWriter, this);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    streamWriter.Close();
                }
            }
            return false;
        }

        bool IDeserializar.Xml(string path, out Fruta fruta)
        {
            bool retorno = false;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ruta += "\\" + path;
            fruta = null;
            if (File.Exists(ruta))
            {
                StreamReader streamReader = new StreamReader(ruta);
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                    fruta = (Manzana)xmlSerializer.Deserialize(streamReader);
                }
                catch(Exception e)
                {
                    retorno = false;
                }
                finally
                {
                    streamReader.Close();
                }
            }            
            return retorno;
        }
    }
}
