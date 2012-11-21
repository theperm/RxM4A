using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Reactive.Linq;

namespace RxM4AExampleSolution
{
    [Activity(Label = "RxM4AExampleSolution", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var obs = Observable.Interval(TimeSpan.FromSeconds(3));

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                Toast.MakeText(this, "Starting Subscription", ToastLength.Long);

                obs.Subscribe(x =>
                {
                    Console.WriteLine(x);
                });

            };
        }
    }
}

