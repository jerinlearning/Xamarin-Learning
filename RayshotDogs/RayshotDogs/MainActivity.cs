using Android.App;
using Android.Widget;
using Android.OS;

namespace RayshotDogs
{
    [Activity(Label = "RayshotDogs", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            int Count = 1;
            Button button = FindViewById<Button>(Resource.Id.Order);
            button.Click += delegate { button.Text = string.Format("{0} clicks", Count++); };
        }
    }
}

