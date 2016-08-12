using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App3
{
    [Activity(Label = "MuayThaiActivity")]
    public class MuayThaiActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MuayThaiLayout);

            Button button = FindViewById<Button>(Resource.Id.MuayThaiButton);

            button.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}