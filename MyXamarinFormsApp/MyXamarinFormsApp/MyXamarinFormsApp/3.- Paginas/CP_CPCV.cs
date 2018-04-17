using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyXamarinFormsApp
{
	public class CP_CPCV : ContentPage
	{
        CV_ContentView cv = new CV_ContentView();
        public CP_CPCV ()
		{
            
			Content = new StackLayout {
				Children = {
				}
			};
		}
	}
}