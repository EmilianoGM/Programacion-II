using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19.Entidades
{
  interface ISerializableXML
  {
    string Path { get; set; }
    bool SerializarXML();
    void Deserializar();
  }
}
