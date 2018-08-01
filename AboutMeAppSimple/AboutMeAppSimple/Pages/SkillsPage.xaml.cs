using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMeAppSimple.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeAppSimple.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
		public SkillsPage ()
		{
			InitializeComponent ();

		    ObservableCollection<Skill> skills = new ObservableCollection<Skill>
		    {
		        new Skill
		        {
		            Name = "C#",
		            ShortDescription = "C# Programming",
		            MoreInfo = "I am fluent in C# and have 10 years of experience with it",
                    Icon="csharp.png"
		        },
		        new Skill
		        {
		            Name = "Speaking",
		            ShortDescription = "Speaking at conferences",
		            MoreInfo = "I have spoken at dozens of conferences around the USA",
		            Icon="speaking.png"
		        },
		        new Skill
		        {
		            Name = "Teaching",
		            ShortDescription = "Teaching at college level",
		            MoreInfo = "I have tought college courses for five years",
		            Icon="teacher.png"
		        },
		        new Skill
		        {
		            Name = "Innovation",
		            ShortDescription = "Solution Innovator",
		            MoreInfo = "I design innovative solutions to business problems",
		            Icon="innovation.png"
		        },
		        new Skill
		        {
		            Name = "Apps",
		            ShortDescription = "App Development",
		            MoreInfo = "I develop mobile apps for a variety of platforms",
		            Icon="apps.png"
		        }
            };

		    SkillsListView.ItemsSource = skills;
		}

	    private void SkillsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {

	        if (e.SelectedItem == null)
	        {
	            return;
	        }

	        Skill selectedSkill = e.SelectedItem as Skill;

	        (sender as ListView).SelectedItem = null;

	        Navigation.PushAsync(new SkillDetailPage(selectedSkill));
	    }
	}
}