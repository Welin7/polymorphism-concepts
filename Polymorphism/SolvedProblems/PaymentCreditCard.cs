using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.SolvedProblems
{
    public class PaymentCreditCard : PaymentRight
    {
        public override void Pay()
        {
            Console.WriteLine($"The {this.Description} was paid on valor of {this.Price} Credit Card type");
        }
    }
}
