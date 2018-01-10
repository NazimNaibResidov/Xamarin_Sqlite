using App2.Droid.ConnectionHalper;
using App2.Helpers;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace App2.Droid.ConnectionHalper
{
  public  class GetDroidConnection : ISqlConnection
    {
        public SQLiteConnection GetConnection()
        {
            string DocumnetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(DocumnetPath,App.dbName);
            var paltform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(paltform, path);
            return connection;
        }
    }
}