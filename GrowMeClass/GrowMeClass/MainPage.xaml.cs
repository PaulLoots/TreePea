using GrowMeClass.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace GrowMeClass
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Plant plant = new Plant();

        private TimeKeeper timeKeeper = new TimeKeeper();
        
        private static Timer timer;
        public MainPage()
        {
            InitializeComponent();

            UpdateUI();
            StartTimer();

           
        }

        async void EditNameTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RenamePlant());
        }

        private void waterButton_Clicked(object sender, EventArgs e)
        {
            ResetTimer();

            plant.giveWater();

            UpdateUI();

        }

        void UpdateUI()
        {
            int plantXp = plant.Xp;

            if(plantXp < 1)
            {
                levelLabel.Text = "Not Planted";
                xpLabel.Text = "tap the water button to plant";
            } else
            {
                levelLabel.Text = "Level " + Level.GetLevelFromXp(plantXp).ToString();
                xpLabel.Text = plantXp.ToString();
            }

            if(plantNameButton.Text != plant.PlantName)
            {
                plantNameButton.Text = plant.PlantName;
            }

            Device.BeginInvokeOnMainThread(async () =>
            {
                plantImage.Source = "plant_" + plant.CurrentPlantState + "_" + (Level.GetLevelFromXp(plantXp) + 1).ToString();

                if (plant.CurrentPlantState == PlantState.withered)
                {
                    PlantWithered();
                }
            });
        }

        private async void PlantWithered()
        {
            await DisplayAlert("Withered", "Your Plant Has Died", "New Plant");

            plant.Xp = 0;
            plant.CurrentPlantState = PlantState.healthy;
            ResetTimer();

            UpdateUI();
        }

        private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimeData;
            timer.Start();
        }

        private void ResetTimer()
        {
            timeKeeper.StartTime = DateTime.Now;

            StartTimer();
        }

        public void UpdateTimeData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

            PlantState newPlantState = plant.CurrentPlantState;

            if(plant.PlantName != plantNameButton.Text)
            {
                plantNameButton.Text = plant.PlantName.ToString();
            }

            if(timeElapsed.TotalSeconds < 10)
            {
                newPlantState = PlantState.healthy;
            }
            else if (timeElapsed.TotalSeconds < 20)
            {
                newPlantState = PlantState.nothealthy;
            } 
            else if(timeElapsed.TotalSeconds >= 20)
            {
                newPlantState = PlantState.withered;
            }
           
            if(newPlantState != plant.CurrentPlantState)
            {
                plant.CurrentPlantState = newPlantState;
                UpdateUI();
            }
        }
    }
}
