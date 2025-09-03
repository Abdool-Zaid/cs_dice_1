using System.Runtime.Serialization;

namespace Cs_dice_1
{
     public class Program
    {
        static void Main(string[] args)
        {
            // welcome 
            // roll loop
            // accept ndD from cmd
            // if follow, roll dice 
            // if not follow, show command 

            System.Console.WriteLine(@"[PH] welcome text"); //TODO: change to welcome message

            while (true)
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("please enter a valid dice roll");
                }
                else if (input == @"/bye")
                {
                    System.Console.WriteLine("goodbye");
                    break;
                }
                else
                {
                    var roll = Cs_dice_1.Math.Roll(20);
                    //    if(roll.Status )
                    System.Console.WriteLine(roll.Payload);
                }

            }



        }
    }
}