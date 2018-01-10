using App2.Helpers;
using App2.UWP.ConnectionHelper;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using Windows.Storage;

[assembly:Xamarin.Forms.Dependency(typeof(GetWinPahoneConnection))]
namespace App2.UWP.ConnectionHelper
{
    public class GetWinPahoneConnection : ISqlConnection
    {
        public SQLiteConnection GetConnection()
        {
            var path = System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, App2.App.dbName);
            var Platform =new  SQLitePlatformWinRT();
            var connection = new SQLiteConnection(Platform, path);
            return connection;
        }
    }
}
