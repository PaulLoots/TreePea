using System.Collections.Generic;

namespace GrowMeClass.Interfaces
{
    public interface IDragAndDropHoverableView
    {
        void OnHovered(List<IDragAndDropMovingView> views);
    }
}