using Projeto01.Model;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Projeto01.Database
{
    public class TarefasDataAcess
    {
        private readonly SQLiteConnection _database;

        public TarefasDataAcess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }
        public List<Tarefa> GetTarefas()
        {
            return _database.Table<Tarefa>().ToList();
        }
        public int SalvarTarefa(Tarefa tarefa)
        {
            return _database.Insert(tarefa);
        }
        public int AtualizarTarefa(Tarefa tarefa)
        {
            return _database.Update(tarefa);
        }
        public int ExcluirTarefa(Tarefa tarefa)
        {
            return _database.Delete(tarefa);
        }
    }
}
