using App2.views;
using System;
using App2.Helpers;
using App2.Model;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
        public ListPage()
        {
            InitializeComponent();
            List<Student> std = new List<Student>();
            SQLiteManagers mg = new SQLiteManagers();
            std = mg.GetAll().ToList();
            lst.BindingContext = std;

        }
        private void onmenuinsert(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Insertpage());
        }

    }
}