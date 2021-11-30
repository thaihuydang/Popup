using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using Xamarin.CommunityToolkit.Extensions;

namespace MauiApp4
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			Navigation.ShowPopup(new PopupService());
		}
	}
}
