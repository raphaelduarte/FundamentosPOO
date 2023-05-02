using FundamentosPOO.NotificationContext;

namespace FundamentosPOO.SharedContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; }

    public Base()
    {
        Id = Guid.NewGuid();
    }
}