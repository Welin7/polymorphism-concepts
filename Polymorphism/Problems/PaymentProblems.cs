
namespace Polymorphism.Problems
{
    public class PaymentProblems
    {
        public string? Description { get; set; }
        public double Price { get; set; }
        public ETypePayment TypePayament { get; set; }

        public void Pay()
        {
            switch (this.TypePayament)
            {
                case ETypePayment.Billet:
                    Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Billet type");
                    break;

                case ETypePayment.CreditCard:
                    Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Credit Card type");
                    break;

                case ETypePayment.Pix:
                    Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Pix type");
                    break;
            }
        }
    }
}
