﻿namespace LayoutsDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new StackLayoutDemo();
		//MainPage = new HorizontalStackLayoutDemo();		
		//MainPage = new AbsoluteLayoutDemo();
		MainPage = new FlexLayoutDemo();
	}
}
