﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Sinavornek
{
    class Connectionyapici
    {
        public static SqlConnection baglantiyagec()
        {
            SqlConnection baglanti = new SqlConnection();

            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\okul.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            return baglanti;
        }
    }
}
