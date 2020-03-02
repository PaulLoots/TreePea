using System;
using System.Collections.Generic;
using System.Text;

namespace GrowMeClass.Objects
{
    public enum PlantState
    {
        healthy,
        nothealthy,
        withered
    }

    public class PlantStates
    {
        public static string GetPlantString(PlantState plantState)
        {
            switch (plantState)
            {
                case PlantState.healthy:
                    return "healthy";
                case PlantState.nothealthy:
                    return "nothealthy";
                case PlantState.withered:
                    return "withered";
                default:
                    return "dirt";
            }
        }

        public static PlantState GetPlantState(string plantState) 
        { 
        
            switch (plantState)
            {
                case "healthy":
                    return PlantState.healthy;
                case "nothealthy":
                    return PlantState.nothealthy;
                case "withered":
                    return PlantState.withered;
                default:
                    return PlantState.healthy;
            }
        }
    }
}
