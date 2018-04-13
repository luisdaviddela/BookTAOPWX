using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace MyXamarinFormsApp
{
    public class CP_MyCSharpView : ContentPage
    {
        public CP_MyCSharpView()
        {
            var lbl_1 = new Label()
            {
                Text = "El arte de programar con",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20
            };
            var lbl_2 = new Label()
            {
                Text = "Xamarin",
                HorizontalOptions = LayoutOptions.Center,
                FontAttributes= FontAttributes.Bold,
                FontSize = 40
            };
            var E_usuario = new Entry()
            {
                Placeholder="Introduce tu usuario",
                Keyboard = Keyboard.Email
            };
            var E_contrasenia = new Entry()
            {
                Text = "Xamarin.Forms",
                IsPassword= true
            };
            var btn_login = new Button()
            {
                Text="Iniciar sesión",
                BackgroundColor= Color.DarkCyan,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Italic
            };

            Content = new StackLayout()
            {
                Padding= 30,
                Spacing = 10,
                BackgroundColor = Color.LightGray,
                Children = { lbl_1, lbl_2,E_usuario,E_contrasenia,btn_login }
            };
        }
    }
}
