using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyXamarinFormsApp
{
	public class CV_ContentView : ContentPage
	{
		public CV_ContentView ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}