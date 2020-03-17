using GrowMeClass.Extensions;
using GrowMeClass.Interfaces;
using Xamarin.Forms;

namespace GrowMeClass.Components
{
    public class DragAndDropSample3MovingView : Frame, IDragAndDropMovingView
    {
        public double ScreenX { get; set; }
        public double ScreenY { get; set; }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            this.InitializeDragAndDrop();
        }
    }
}