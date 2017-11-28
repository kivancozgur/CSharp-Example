using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace stok_programi
{
    class ConnectionYapici
    {
        public static OleDbConnection baglantiyagec()
        {
           OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");
           OleDbDataAdapter adtr = new OleDbDataAdapter();
           OleDbCommand kmt = new OleDbCommand();
            return bag;
        }
    }
}
