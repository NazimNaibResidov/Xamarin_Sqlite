using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;


namespace App2.Helpers
{
   public interface ISqlConnection
    {
        SQLiteConnection GetConnection();
    }
}
