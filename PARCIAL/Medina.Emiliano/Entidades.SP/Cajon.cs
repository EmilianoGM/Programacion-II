using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades.SP
{
    public class Cajon<T> : ISerializar
    {
        public delegate void MiDelegado(double precio);
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _preciounitario;

        public event MiDelegado EventoPrecio; 

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double total = this._elementos.Count * this._preciounitario;
                return total;
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._preciounitario = precioUnitario;
        }

        public static Cajon<T> operator + (Cajon<T> cajon, T elemento)
        {
            if(!Object.Equals(null, cajon) && !Object.Equals(null, elemento))
            {
                if(cajon._elementos.Count < cajon._capacidad)
                {
                    cajon._elementos.Add(elemento);
                    if (cajon.PrecioTotal > 55)
                    {
                        cajon.EventoPrecio(cajon.PrecioTotal);
                    }
                }
                else
                {
                    throw new CajonLLenoException();
                }
            }
            return cajon;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Capacidad: " + this._capacidad.ToString() + "Precio: " + this._preciounitario.ToString() + "\n";
            foreach(T elemento in this._elementos)
            {
                retorno += elemento.ToString() + "\n";
            }
            return retorno;
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
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
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

        public bool EliminarFruta(int id)
        {
            return false;
        }
    }
}
