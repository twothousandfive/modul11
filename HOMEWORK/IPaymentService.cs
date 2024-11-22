namespace HOMEWORK;

public interface IPaymentService
{
    bool ProcessPayment(int bookingId, string paymentMethod, decimal amount);
    bool VerifyPayment(int paymentId);
}

public class PaymentService : IPaymentService
{
    public bool ProcessPayment(int bookingId, string paymentMethod, decimal amount)
    {
        // Логика обработки платежа
        return true; // Пример успешной оплаты
    }

    public bool VerifyPayment(int paymentId)
    {
        // Логика проверки платежа
        return true; // Пример успешной проверки
    }
}
