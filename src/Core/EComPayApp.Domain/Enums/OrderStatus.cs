namespace EComPayApp.Domain.Enums
{
    public enum OrderStatus :int 
    {
        Pending = 0,
        PaymentReceived = 1,
        PaymentFailed = 2
    }
}
