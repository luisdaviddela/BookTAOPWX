using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MyXamarinFormsApp
{
    public class Tabla_Informacion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string Genero { get; set; }
    }
}
