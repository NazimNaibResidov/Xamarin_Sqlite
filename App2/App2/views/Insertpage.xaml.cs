using App2.Model;
using App2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Insertpage : ContentPage
	{
		public Insertpage ()
		{
			InitializeComponent ();
		}
        private void oninsert(object sender,EventArgs e)
        {
            EntryCell cl = new EntryCell();
            SQLiteManagers mg = new SQLiteManagers();
            Student sd = new Student();
            sd.Name = this.txtName.Text.ToString();
            sd.SurName = this.txtSurname.Text;
            sd.RegeditDate = DateTime.Now;
            if(mg.insert(sd))
            {
                DisplayAlert("it is successful", "Ok","Cancle");
             


            }
            else
            {
                DisplayAlert("permiton error", "Ok", "Cancle");
            }
        }

    }
}