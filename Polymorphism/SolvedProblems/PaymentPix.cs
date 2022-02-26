
namespace Polymorphism.SolvedProblems
{
    public class PaymentPix : PaymentRight
    {
        public override void Pay()
        {
            Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Pix type");
        }
    }
}
