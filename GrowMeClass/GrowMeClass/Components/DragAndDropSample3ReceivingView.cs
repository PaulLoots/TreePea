using System.Collections.Generic;
using System.Linq;
using GrowMeClass.Interfaces;
using Xamarin.Forms;
using GrowMeClass.Objects;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using GrowMeClass;

namespace GrowMeClass.Components
{
    public class DragAndDropSample3ReceivingView : Frame, IDragAndDropHoverableView, IDragAndDropReceivingView
    {
        private Plant plant = new Plant();


        public void OnHovered(List<IDragAndDropMovingView> views)
        {
            Opacity = views.Any() ? .3 : 1;
        }

        public void OnDropReceived(IDragAndDropMovingView view)
        {
            if (view is DragAndDropSample3MovingView sender)
            {
                BackgroundColor = sender.BackgroundColor;
                plant.givePower();
                //new MainPage().UpdateUI();
                MessagingCenter.Send<App>((App)Application.Current, "CallMethod");
            }
        }
    }
}