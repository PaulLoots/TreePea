using System;
using System.Collections.Generic;
using System.Text;

namespace GrowMeClass.Objects
{
    public class Plant
    {
        const string plantStateKey = "plantState";
        const string plantXpKey = "plantXp";
        const string plantNameKey = "plantName";
        public PlantState CurrentPlantState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(plantStateKey))
                {
                    return PlantStates.GetPlantState((string)App.Current.Properties[plantStateKey]);
                } 
                else
                {
                    return PlantState.healthy;
                }

            }
            set
            {
                App.Current.Properties[plantStateKey] = PlantStates.GetPlantString(value);
            }
        }

        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(plantXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[plantXpKey]);
                    return (int)App.Current.Properties[plantXpKey];
                } else
                {
                    return 0;
                }
            }

            set
            {
                App.Current.Properties[plantXpKey] = value;
            }
        }

        public string PlantName
        {
            get
            {
                if (App.Current.Properties.ContainsKey(plantNameKey))
                {
                    return (string)App.Current.Properties[plantNameKey];
                }
                else
                {
                    return "No Name";
                }

            }
            set
            {
                App.Current.Properties[plantNameKey] = value;
            }
        }
        public Plant()
        {

        }

        public void giveWater()
        {
            Xp = Xp + 500;
        }
    }
}
