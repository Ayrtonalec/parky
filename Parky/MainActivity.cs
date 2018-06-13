﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using System.IO;
using SQLite;

namespace Parky
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button mapButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mapButton = FindViewById<Button>(Resource.Id.mapButton);
            mapButton.Click += delegate
            {
                var intent = new Intent(this, typeof(MapActivity));
                StartActivity(intent);
            };
        }
    }
}

