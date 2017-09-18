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
    [Activity(Label = "Ray's Hot Dogs - About")]
    public class AboutActivity : Activity
    {
        private TextView phoneNumberTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AboutView);
            FindViews();
            HandleEvents();
        }

        public void FindViews()
        {
            phoneNumberTextView = FindViewById<TextView>(Resource.Id.phoneNumberTextView);
        }
        private void HandleEvents()
        {
            phoneNumberTextView.Click += PhoneNumberTextView_Click;
        }

        private void PhoneNumberTextView_Click(object sender, EventArgs e)
        {
            //if ((int)Build.VERSION.SdkInt >= 23)
            //{
            //    RequestPermissions(new[] { Manifest.Permission.CallPhone }, 0);
            //}
            try
            {
                var callIntent = new Intent(Intent.ActionCall, Android.Net.Uri.Parse("tel:" + phoneNumberTextView.Text));
                StartActivity(callIntent);
            }
            catch (Exception ex)
            {
                using (var x = new AlertDialog.Builder(this))
                {
                    x.SetMessage(ex.Message);
                    x.Show();
                }
            }
        }
    }
}