using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DBXML
{
    public class Daten
    {
        private string name;
        private string ide;
        private string prog;
        private string dbname;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string IDE
        {
            get { return ide; }
            set { ide = value; }
        }

        public string PROG
        {
            get { return prog; }
            set { prog = value; }
        }

        public string DBNAME
        {
            get { return dbname; }
            set { dbname = value; }
        }
    }
}
