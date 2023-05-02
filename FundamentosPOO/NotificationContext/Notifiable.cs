namespace FundamentosPOO.NotificationContext;

public abstract class Notifiable
{
    public List<Notification> Notifications { get; set; }

    public Notifiable(List<Notification> notifications)
    {
        Notifications = new List<Notification>();
    }

    protected Notifiable()
    {
        throw new NotImplementedException();
    }

    public void AddNotification(Notification notification)
    {
        Notifications.Add(notification);
    }
    
    public void AddNotifications(IEnumerable<Notification> notifications)
    {
        Notifications.AddRange(notifications);
    }

    public bool IsInvalid => Notifications.Any();
}