using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Quiz_Coronavirus.Activities
{
    [Activity(Label = "QuizDescriptionActivity", Theme = "@style/AppTheme")]
    public class QuizDescriptionActivity : AppCompatActivity
    {


        TextView quizTopicTextView;
        TextView quizDescriptionTextView;
        ImageView quizImageView;
        Button startQuizButton;

        //variables
        public string quizTopic;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.selected_topic);

            quizTopicTextView = (TextView)FindViewById(Resource.Id.quizTopicText);
            quizDescriptionTextView = (TextView)FindViewById(Resource.Id.quizDescriptionText);
            quizImageView = (ImageView)FindViewById(Resource.Id.quizImage);
            startQuizButton = (Button)FindViewById(Resource.Id.startQuizButton);

            quizTopic = Intent.GetStringExtra("TOPIC");
            quizTopicTextView.Text = quizTopic;
            quizImageView.SetImageResource(GetImage(quizTopic));
        }

        int GetImage(string TOPIC)
        {
            int imageInt = Resource.Drawable.space;

            if (TOPIC == "History")
            {
                imageInt = Resource.Drawable.history;
            }
            else if (TOPIC == "Geography")
            {
                imageInt = Resource.Drawable.geography;

            }
            else if (TOPIC == "Space") 
            {
                imageInt = Resource.Drawable.space;

            }
            else if (TOPIC == "Business")
            {
                imageInt = Resource.Drawable.business;
            }

            else if (TOPIC == "Programming")

            {
                imageInt = Resource.Drawable.programming;
            }
            else if (TOPIC == "Engineering")
            {

                imageInt = Resource.Drawable.engineering;
            }
            
            return imageInt;
        








        }
    }
}