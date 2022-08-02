using Factorymethod.Factory;
using Factorymethod.Domain;
namespace Factorymethod
{
    public class Factorymethods
    {
        public static void Main()
        {
            Console.WriteLine("Bald shop");
            Console.WriteLine("What do u want");
            Console.WriteLine("Bed with tea => write 't'");
            Console.WriteLine("Bed with bee => write 'b'");
            string Type = Console.ReadLine();

            FactoryFirst factory = GetFactory(Type);
            IMAGAZIN iMAGAZI = factory.GetMAGAZIN();

            Console.WriteLine("You sucesfully created:");

            Console.WriteLine($"\tPrice:\t{iMAGAZI.Price}\n" +
                $"\tDescription:\t{iMAGAZI.Description}");

            Console.ReadLine();
        }
        private static FactoryFirst GetFactory(string Type) =>
            Type.ToLower() switch
            {
                "t" => new FactoryBedTea(100,"Bed with tea"),
                "b" => new FactoryBedBee(120,"Bed with bee"),
                _ => throw new Exception()
            };
    }
}