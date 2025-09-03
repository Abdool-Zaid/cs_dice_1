using System.Runtime.Serialization;

namespace Cs_dice_1
{
     public class Program
    {
        static void Main(string[] args)
        {

                    Cs_dice_1.View.Show(@"[PH] welcome text");//TODO: change to welcome message

            while (true)
            {
                string? input = Console.ReadLine();
                input = string.IsNullOrWhiteSpace(input) ? "bad" : input;// pre check needed to assert not null
                var Payload = Cs_dice_1.Utils.Check_input(input);
                if (input == @"/bye")
                {
                    Cs_dice_1.View.Show("goodbye");
                    break;
                }
                if (Payload.Status > 0)
                {
                    //TODO: add switch case here to handle different errors
                    Cs_dice_1.View.Show("please enter a valid dice roll");
                }
                else
                {
                    var roll = Cs_dice_1.Math.Roll_dice(Payload.Payload);
                    Cs_dice_1.View.Show_all_results(roll.Payload);
                }

            }



        }
    }
}