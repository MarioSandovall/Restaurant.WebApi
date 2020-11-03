namespace Domain.Utils
{
    public enum CashRegisterStatusEnum
    {
        Open = 1,
        Close = 2,
        Cancel = 3
    }

    public enum OrderStatusEnum
    {
        Pending = 1,
        Delivered = 2,
        Cancel = 3
    }

    public enum RoleEnum
    {
        Cashier = 1,
        Chef = 2,
        Admin = 3
    }

    public enum PaymentTypeEnum
    {
        None = 0,
        Cash = 1,
        CreditCard = 2,
        Check = 3
    }
}
