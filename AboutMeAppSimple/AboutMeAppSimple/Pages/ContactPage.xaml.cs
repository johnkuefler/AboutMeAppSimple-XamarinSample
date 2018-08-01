using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeAppSimple.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

	    private void Submit_Clicked(object sender, EventArgs e)
	    {
	        if (String.IsNullOrEmpty(NameEntry.Text) ||
	            String.IsNullOrEmpty(EmailEntry.Text) ||
	            String.IsNullOrEmpty(MessageEntry.Text))
	        {
	            DisplayAlert("Error", "Please enter all data!", "Ok");
            }
	        else
	        {
               DisplayAlert("Success", "Your Message Was Submitted!", "Ok");
	        }
	    }
	}
}