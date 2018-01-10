using Xamarin.Forms.Platform.iOS;
using App2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;
using App2.iOS.ConnectionHelper;

[assembly:Dependency(typeof(GetISOConnection))]
namespace App2.iOS.ConnectionHelper
{
    public class GetISOConnection : ISqlConnection
    {
        public SQLiteConnection GetConnection()
        {
            var DocumnetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var Path = System.IO.Path.Combine
                (DocumnetPath,App2.App.dbName);
            var Platform = new  SQLitePlatformIOS();
            var connection = new SQLiteConnection(Platform, Path);
            return connection;
        }
    }
}