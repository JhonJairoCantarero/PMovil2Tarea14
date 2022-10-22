using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM2E144.Models
{
    public class Sites
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Byte[] foto { get; set; }
    }
}
