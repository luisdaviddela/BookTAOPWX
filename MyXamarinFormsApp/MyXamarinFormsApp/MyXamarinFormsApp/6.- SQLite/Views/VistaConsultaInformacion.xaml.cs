using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;

namespace MyXamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaConsultaInformacion : ContentPage
	{
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<Tabla_Informacion> _TablaRegistro;
     
		public VistaConsultaInformacion ()
		{
			InitializeComponent ();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
        }
        protected async override void OnAppearing()
        {
            try
            {
                var ResulRegistros = await _conn.Table<Tabla_Informacion>().ToListAsync();
                _TablaRegistro = new ObservableCollection<Tabla_Informacion>(ResulRegistros);
                ListaRegistros.ItemsSource = _TablaRegistro;
                base.OnAppearing();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}