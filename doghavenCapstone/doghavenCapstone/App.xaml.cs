﻿using doghavenCapstone.DetailsPage;
using doghavenCapstone.InitialPages;
using doghavenCapstone.LocalDBModel;
using doghavenCapstone.MainPages;
using doghavenCapstone.MessagesComponents;
using doghavenCapstone.Model;
using doghavenCapstone.OtherPageFunctions;
using doghavenCapstone.PreventerPage;
using Microsoft.WindowsAzure.MobileServices;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doghavenCapstone
{
    public partial class App : Application
    {
        
        public static MobileServiceClient client = new MobileServiceClient("https://myserver-doghaven.azurewebsites.net");
        public static string DatabaseLocation = string.Empty;
        public static string flagForSellerApplication = "";
        public static bool isAlreadyRead = false;
        
        public static string loadingMessage = "";
        public static string user_id = "";
        public static string fullName = "";
        public static string buttonName = "";
        public static int uploadFlag = 0;
        //Doginformation
        public static string dog_id = "";
        public static string dog_name = "";
        public static string dog_image = "";
        public static string dog_gender = "";
        public static string dog_purposeID = "";
        public static string dog_breedID = "";
        public static string dog_userID = "";

        public static int doginfo_flag = 2;
        public static bool _updateflag = true;

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;
            MainPage = new NavigationPage(new IntroPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
