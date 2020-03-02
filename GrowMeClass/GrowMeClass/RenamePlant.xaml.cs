using GrowMeClass.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GrowMeClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RenamePlant : ContentPage
    {
        private Plant plant = new Plant();

        public RenamePlant()
        {
            InitializeComponent();
        }

        async void SavePlantName(object sender, EventArgs e)
        {
            plant.PlantName = PlantNameInput.Text;
            await Navigation.PopModalAsync();
        }
    }
}