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
using RayshotDogs.Core.Model;
using RayshotDogs.Core.Service;
using RayshotDogs.Utility;

namespace RayshotDogs
{
    [Activity(Label = "Hot Dog Detail", Icon = "@drawable/icon")]
    public class HotDogDetailActivity : Activity
    {
        private ImageView hotDogImageView;
        private TextView hotDogNameTextView;
        private TextView shortDescriptionTextView;
        private TextView descriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
        private Button cancelButton;
        private Button orderButton;

        private HotDogDataService dataService;
        private HotDog selectedHotDog;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HotDogDetailView);

            dataService = new HotDogDataService();
            //selectedHotDog = dataService.GetHotDogById(Intent.GetIntExtra("selectedHotDogId", 1));

            var selectedHotDogId = Intent.Extras.GetInt("selectedHotDogId");
            selectedHotDog = dataService.GetHotDogById(selectedHotDogId);

            FindViews();
            BindData();
            HandleEvents();
        }

        private void FindViews()
        {
            hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogDetailImage);
            hotDogNameTextView = FindViewById<TextView>(Resource.Id.hotDogNameTextView);
            shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            amountEditText = FindViewById<EditText>(Resource.Id.amoutEditText);
            cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }

        private void BindData()
        {
            
            hotDogNameTextView.Text = selectedHotDog.Name;
            shortDescriptionTextView.Text = selectedHotDog.ShortDescription;
            descriptionTextView.Text = selectedHotDog.Description;
            priceTextView.Text = "Price: $" + selectedHotDog.Price;

            //var imageBitMap = ImageHelper.GetImageBitmapFromUrl("http://www.ndtv.com/cooks/images/image3%281%29.jpg");
            //hotDogImageView.SetImageBitmap(imageBitMap);
        }

        private void HandleEvents()
        {
            orderButton.Click += OrderButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var amount = Int32.Parse(amountEditText.Text);

            var intent = new Intent();
            intent.PutExtra("selectedHotDogId", selectedHotDog.HotDogId);
            intent.PutExtra("amount", amount);

            SetResult(Result.Ok, intent);
            this.Finish();
            //var amount = int.Parse(amountEditText.Text);

            //using (var dialog = new AlertDialog.Builder(this))
            //{
            //    dialog.SetTitle("Confirmation");
            //    dialog.SetMessage("Your hot dog has been added to the cart!");
            //    dialog.Show();
            //}
        }
    }
}