using SQLite;
using Projeto01.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Database_Android))]
namespace Projeto01.Droid
{
    public class Database_Android : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto01.db3";

            var caminhoDB = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nomeDB);

            return new SQLiteConnection(caminhoDB, false);
        }
    }
}