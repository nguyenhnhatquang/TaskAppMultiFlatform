﻿using TaskApp.Sources.Views;

namespace TaskApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new OnboardingView();
	}
}
