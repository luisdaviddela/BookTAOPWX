using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyXamarinFormsApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //-----------------GRIDS
            //MainPage = new G_Grid1();
            //MainPage = new G_Grid2();

            //-----------------PÁGINAS
            //MainPage = new P_ContentPage();
            //MainPage = new P_TabbedPage();
            //MainPage = new P_TabbedPage2();
            //MainPage = new P_CarouselPage();
            //MainPage = new P_CarouselPage2();

            //------------ CONTENT PAGE / CONTENTVIEW
            //MainPage = new CP_Content1();

            //-----------------NuGet Packages
            //MainPage = new NuG_Microcharts();
            //MainPage = new NuG_Microcharts2();

            //------------ Almacenamiento SQLite
            //MainPage = new NavigationPage(new VistaCapturaInformacion());
            //MainPage = new VistaConsultaInformacion();
            
            //------------ Imagenes
            //MainPage = new ImagenesView();
            //MainPage = new ImagenesGrid();
            
            //------------ Imagenes

            MainPage = new NavigationPage(new Pagina1());

        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
