using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Community_v1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port = 3306;username = root; passwort root;");
    }
}
