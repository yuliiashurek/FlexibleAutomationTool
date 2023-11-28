using NotificationFactoryService.Printers;

namespace NotificationFactoryService.Senders
{
    public interface ISender
    {
        public void Send(IPrint printItem);
    }
}
