namespace FundamentosPOO.NotificationContext;

public sealed class Notification
{
    public Notification()
    {
    }
    
    public Notification(string propety, string message)
    {
        Propety = propety;
        Message = message;
    }

    public string Propety { get; set; }
    public string Message { get; set; }
}