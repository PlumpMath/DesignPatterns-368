﻿using System;
using DesignPatterns.StatePattern;
using DesignPatterns.AdapterPattern;

namespace DesignPatterns
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the world of design patterns...");

			bool isRunning = true;

			PrintHelp ();

			while (isRunning) 
			{
				var inputKey = Console.ReadKey ();

				switch (inputKey.KeyChar.ToString()) 
				{
				case"A":
					RunAdapterExample ();
					break;
				case "S":
					RunStateExample ();
					break;
				case"H":
					PrintHelp ();
					break;
				case"Q":
					isRunning = false;
					break;
				}
						
			}
		}

		private static void PrintHelp()
		{
			Console.WriteLine ("Type A for Adapter Patten, S for state pattern, H for help or Q to quit");
		}

		private static void RunAdapterExample()
		{
			CarAdapterClient client = new CarAdapterClient ();
			client.TestDrive ();
		}

		private static void RunStateExample()
		{
			ScrumBoardClient.RunScrumBoardClient();
		}

	}
}
