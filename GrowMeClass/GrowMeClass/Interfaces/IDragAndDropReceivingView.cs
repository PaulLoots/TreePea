namespace GrowMeClass.Interfaces
{
    public interface IDragAndDropReceivingView
    {
        void OnDropReceived(IDragAndDropMovingView view);
    }
}