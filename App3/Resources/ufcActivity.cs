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
    [Activity(Label = "ufcActivity")]
    public class ufcActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ufcLayout);

            Button button = FindViewById<Button>(Resource.Id.ufcButton);

            button.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}