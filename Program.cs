namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string company = "Firma :";

            string adidasCompany = "Adidas";
            string nikeCompany = "Nike";
            string gucciCompany = "Gucci";
            string totalPrice = "Hamisinin birlikde qiymeti ($) :";
            string numberofshoes = "Ayaqqabi Sayi :";
            string priceofShoes = "Birinin qiymeti ($) :";

            int adidas = 4;
            int adidasPrice = 200;

            int gucci = 2;
            int gucciPrice = 200;

            int nike = 1;
            int nikePrice = 150;

            float totalAdidas = adidas * adidasPrice;
            float totalGucci = gucci * gucciPrice;
            float totalNike = nike * nikePrice;

            Console.WriteLine(company);
            Console.WriteLine(adidasCompany);
            Console.WriteLine(numberofshoes);
            Console.WriteLine(adidas);
            Console.WriteLine(priceofShoes);
            Console.WriteLine(adidasPrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalAdidas);

            Console.WriteLine(company);
            Console.WriteLine(gucciCompany);
            Console.WriteLine(numberofshoes);
            Console.WriteLine(gucci);
            Console.WriteLine(priceofShoes);
            Console.WriteLine(adidasPrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalGucci);

            Console.WriteLine(company);
            Console.WriteLine(nikeCompany);
            Console.WriteLine(numberofshoes);
            Console.WriteLine(nike);
            Console.WriteLine(priceofShoes);
            Console.WriteLine(nikePrice);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalNike);
        }
    }
}