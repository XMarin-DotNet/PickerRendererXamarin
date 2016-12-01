using System.Collections.Generic;
using Xamarin.Forms;

namespace TestApp
{
	public partial class TestAppPage : ContentPage
	{
		public TestAppPage()
		{
			InitializeComponent();
			List<string> list = new List<string>(new string[] { "ABC", "CBA", "EDF" });
			this.MyPicker.ItemsSource = list;

		}
	}
}
