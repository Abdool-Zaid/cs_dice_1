using System.Runtime.Serialization;

namespace Cs_dice_1
{
     public class Program
    {
        static void Main(string[] args)
        {
          

            System.Console.WriteLine(@"[PH] welcome text"); //TODO: change to welcome message

            while (true)
            {
                string? input = Console.ReadLine();
                input = string.IsNullOrWhiteSpace(input) ? "bad" : input;// pre check needed to assert not null
                var Payload = Cs_dice_1.Utils.Check_input(input);
                if (Payload.Status > 0 )
                {
                    System.Console.WriteLine("please enter a valid dice roll");//TODO: add switch case here to handle different errors
                }
                else if (input == @"/bye")
                {
                    System.Console.WriteLine("goodbye");
                    break;
                }
                else 
                {
                    var roll = Cs_dice_1.Math.Roll_dice(Payload.Payload);
                    System.Console.WriteLine(roll.Payload);
                }

            }



        }
    }
}