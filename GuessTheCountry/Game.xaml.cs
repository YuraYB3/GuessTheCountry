using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuessTheCountry
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Game : ContentPage
	{


        public Game()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            rightAnswersText.Text = Convert.ToString(PointControl.rightAnswers);
            allAnswersText.Text = Convert.ToString(PointControl.allAnswers);
            wrongAnswersText.Text = Convert.ToString(PointControl.wrongAnswers);
            rightClicked.Clicked += RightClicked_Clicked;
            wrongClicked.Clicked += WrongClicked_Clicked;
            nextClicked.Clicked += NextClicked_Clicked;
            
        }



        private void NextClicked_Clicked(object sender, EventArgs e)
        {
            NexButtonClickedChangeState();
           IdControl.randomInt = IdControl.rand.Next(Countries.images.Count);
            RandomImage.Source= Countries.images[IdControl.randomInt];

        }

        private void WrongClicked_Clicked(object sender, EventArgs e)
        {
            PointControl.IncreaseWrongAnswers();
            wrongAnswersText.Text = Convert.ToString(PointControl.wrongAnswers);
            allAnswersText.Text = Convert.ToString(PointControl.allAnswers);
            ChangeButtonState();
        }



        private void RightClicked_Clicked(object sender, EventArgs e)
        {
            PointControl.IncreaseRightAnswers();
            rightAnswersText.Text = Convert.ToString(PointControl.rightAnswers);
            allAnswersText.Text = Convert.ToString(PointControl.allAnswers);
            ChangeButtonState();
        }
        private void ChangeButtonState()
        {
            rightClicked.IsEnabled = false;
            wrongClicked.IsEnabled = false;
            nextClicked.IsEnabled = true;
        }

        private void NexButtonClickedChangeState()
        {
            rightClicked.IsEnabled = true;
            wrongClicked.IsEnabled = true;
            nextClicked.IsEnabled = false;
        }

        void OnImageClicked(object sender, EventArgs args)
        {
            try
            {
                DisplayAlert("Info", $"{Countries.labels[IdControl.randomInt]}", "Okay");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

	}
