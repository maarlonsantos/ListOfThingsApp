using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Model
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}
