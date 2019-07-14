using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.SP
{
    public class Manejadora
    {
        public void ManejadorPrecio(double precio)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ruta += "\\PrecioTotal.txt";
            if (File.Exists(ruta))
            {
                StreamWriter streamWriter = new StreamWriter(ruta, true);
                try
                {
                    streamWriter.WriteLine(DateTime.Now.ToString());
                    streamWriter.WriteLine("Precio del cajon:" + precio.ToString());
                }
                catch (Exception e)
                {
                }
                finally
                {
                    streamWriter.Close();
                }
            }
        }
    }
}
