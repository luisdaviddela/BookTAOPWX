using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinFormsApp
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
