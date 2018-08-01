using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMeAppSimple.Pages;
using Xamarin.Forms;

namespace AboutMeAppSimple
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Bio_Tapped(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new BioPage());
	    }

	    private void Skills_Tapped(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new SkillsPage());

	    }

        private void Contact_Tapped(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new ContactPage());
	    }
    }
}
