using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMeAppSimple.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeAppSimple.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillDetailPage : ContentPage
	{
		public SkillDetailPage (Skill skill)
		{
			InitializeComponent ();

		    this.NameLabel.Text = skill.Name;
		    this.ShortDescriptionLabel.Text = skill.ShortDescription;
		    this.MoreInfoLabel.Text = skill.MoreInfo;
		}
	}
}