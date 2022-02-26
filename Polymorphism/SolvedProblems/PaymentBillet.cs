
namespace Polymorphism.SolvedProblems
{
    public class PaymentBillet : PaymentRight
    {
        public override void Pay()
        {
            Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Billet type");
        }
    }
}
