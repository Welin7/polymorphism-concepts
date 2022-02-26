using Polymorphism.Problems;
using Polymorphism.SolvedProblems;

var payment = new PaymentProblems()
{
    Description = "energy account",
    Price = 225.50,
    TypePayament = ETypePayment.Billet
};

Console.WriteLine("Executing with cyclomatic complexity problem");
payment.Pay();
Console.WriteLine();

Console.WriteLine("Executing solving the cyclomatic complexity problem");
var paymentBillet = new PaymentBillet()
{
    Description = "game pass card",
    Price = 120.55
};
paymentBillet.Pay();
Console.WriteLine();

var paymentCreditCard = new PaymentCreditCard()
{
    Description = "game Fifa 2022",
    Price = 200.15
};
paymentCreditCard.Pay();
Console.WriteLine();

var paymentPix = new PaymentPix()
{
    Description = "payment spootfy",
    Price = 30.42
};
paymentPix.Pay();
Console.ReadLine();

