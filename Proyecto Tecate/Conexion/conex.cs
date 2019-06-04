using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tecate.Conexion
{
        public class Conex : DataConnection
        {
            public Conex() : base("connection")
            {

            }
        }
}
