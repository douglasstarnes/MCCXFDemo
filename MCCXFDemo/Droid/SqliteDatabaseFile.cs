using System;
using System.IO;

using Xamarin.Forms;

using SQLite;

using MCCXFDemo.Droid;

[assembly: Dependency(typeof(SqliteDatabaseFile))]
namespace MCCXFDemo.Droid
{
    public class SqliteDatabaseFile: ISqliteDatabaseFile
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "conference.db";
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}
