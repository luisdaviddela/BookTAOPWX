using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
namespace MyXamarinFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuG_Microcharts2 : ContentPage
	{
        public List<Entry> ObtenerGrafica()
        {
            List<Entry> data = new List<Entry>
            {
                new Entry(100)
                {
                    Label = "El arte",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#aed6f1")
                },new Entry(300)
                {
                    Label = "de programar",
                    ValueLabel = "300",
                    Color = SKColor.Parse("#5dade2")
                },
                new Entry(200)
                {
                    Label = "con Xamarin",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#2e86c1")
                }
            };

            return data;
        }
        public NuG_Microcharts2 ()
		{
			InitializeComponent ();
            grafica1.Chart = new BarChart { Entries = ObtenerGrafica() };
            grafica2.Chart = new LineChart { Entries = ObtenerGrafica() };
            grafica3.Chart = new DonutChart { Entries = ObtenerGrafica() };
            grafica4.Chart = new PieChart { Entries = ObtenerGrafica() };
            grafica5.Chart = new PointChart { Entries = ObtenerGrafica() };
            grafica6.Chart = new RadarChart { Entries = ObtenerGrafica() };
            grafica7.Chart = new RadialGaugeChart { Entries = ObtenerGrafica() };
        }
	}
}