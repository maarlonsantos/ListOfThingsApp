using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Projeto01
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
