using System;
using SQLite;

namespace MCCXFDemo
{
    public interface ISqliteDatabaseFile
    {
        SQLiteConnection GetConnection();
    }
}
