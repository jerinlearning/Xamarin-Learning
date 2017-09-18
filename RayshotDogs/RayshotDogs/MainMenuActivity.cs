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

namespace RayshotDogs
{
    [Activity(Label = "MainMenuActivity", MainLauncher = true)]
    public class MainMenuActivity : Activity
    {
        private Button orderButton;
        private Button cartButton;
        private Button pictureButton;
        private Button mapButton;
        private Button aboutButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainMenuView);

            FindViews();
            HandleEvents();
        }

        private void FindViews()
        {
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
            cartButton = FindViewById<Button>(Resource.Id.cartButton);
            pictureButton = FindViewById<Button>(Resource.Id.takePictureButton);
            mapButton = FindViewById<Button>(Resource.Id.mapButton);
            aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
        }
        private void HandleEvents()
        {
            orderButton.Click += OrderButton_Click;
            aboutButton.Click += AboutButton_Click;
            pictureButton.Click += PictureButton_Click;
        }

        private void PictureButton_Click(object sender, EventArgs e)
        {
            var pictureIntent = new Intent(this, typeof(TakePictureActivity));
            StartActivity(pictureIntent);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var aboutIntent = new Intent(this, typeof(AboutActivity));
            StartActivity(aboutIntent);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var orderIntent = new Intent(this, typeof(HotDogMenuActivity));
            StartActivity(orderIntent);
        }
    }
}