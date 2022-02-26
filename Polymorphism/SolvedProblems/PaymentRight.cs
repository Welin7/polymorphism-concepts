
namespace Polymorphism
{
    public abstract class PaymentRight
    {
        public string? Description { get; set; }
        public double Price { get; set; }
        public abstract void Pay();
    }
}
