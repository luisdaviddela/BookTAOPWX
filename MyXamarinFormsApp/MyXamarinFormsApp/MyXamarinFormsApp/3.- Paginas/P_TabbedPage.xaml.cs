﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinFormsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P_TabbedPage : TabbedPage
    {
        public P_TabbedPage ()
        {
            InitializeComponent();
        }
    }
}