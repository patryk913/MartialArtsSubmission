using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App3
{
    [Activity(Label = "App3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<ImageButton>(Resource.Id.imageButton1);

            button.Click += delegate
            {
                StartActivity(typeof(ufcActivity));
            };
            var button2 = FindViewById<ImageButton>(Resource.Id.imageButton2);

            button2.Click += delegate
            {
                StartActivity(typeof(JuiJitsuActivity));
            };
            var button3 = FindViewById<ImageButton>(Resource.Id.imageButton3);

            button3.Click += delegate
            {
                StartActivity(typeof(MuayThaiActivity));
            };
        }
     }
 }


