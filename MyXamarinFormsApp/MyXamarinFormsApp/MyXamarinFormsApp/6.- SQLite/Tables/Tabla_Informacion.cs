using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MyXamarinFormsApp
{
    public class Tabla_Informacion
    {
        [PrimaryKey, AutoIncrement ,Unique]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
    }
}
