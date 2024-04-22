
using DesignPatterns;

double Mrp = 10000;


//case 1 : Membership card, 10% Discount
ContextCart cart1 = new ContextCart();

cart1.setTier(new LessDiscount());
double totalAmount1 = cart1.TotalAmount(Mrp);
Console.WriteLine("Total amount with Membership Card discount: Rs " + totalAmount1);


//case 2 : Employee card, 20% Discount
cart1.setTier(new HigherDiscount());
double totalAmount2 = cart1.TotalAmount(Mrp);
Console.WriteLine("Total amount with Employee Card discount: Rs " + totalAmount2);

//case 3 : No card, 0% Discount
cart1.setTier(new NoDiscount());
double totalAmount3 = cart1.TotalAmount(Mrp);
Console.WriteLine("Total amount with No Card discount: Rs " + totalAmount3);
