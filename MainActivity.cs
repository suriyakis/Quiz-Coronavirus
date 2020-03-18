using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Quiz_Coronavirus.Assets.Activities;
using Quiz_Coronavirus.Activities;

namespace Quiz_Coronavirus
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity


    {

        Android.Support.V7.Widget.Toolbar toolbar;


        LinearLayout historyLayout;
        LinearLayout spaceLayout;
        LinearLayout geographyLayout;
        LinearLayout engineeringLayout;
        LinearLayout businessLayout;
        LinearLayout programmingLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.activity_main);

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);

            //Setup Toolbar

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);


            // VIews setups

            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geographyLayout);
            engineeringLayout = (LinearLayout)FindViewById(Resource.Id.engineeringLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);


            // click event handlers
            historyLayout.Click += HistoryLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            engineeringLayout.Click += EngineeringLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;

            


        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC","Business");
            StartActivity(intent);

        }



        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC", "Programming");
            StartActivity(intent);

        }





        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC", "Engineering");
            StartActivity(intent);

        }


        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC", "Geography");
            StartActivity(intent);

        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC", "Space");
            StartActivity(intent);


        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {

            
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            Intent.PutExtra("TOPIC", "History");
            StartActivity(intent);


        }
    }
}