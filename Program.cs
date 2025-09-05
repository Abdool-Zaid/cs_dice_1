using System.Runtime.Serialization;

namespace Cs_dice_1
{
     public class Program
    {
        static void Main(string[] args)
        {

            Cs_dice_1.View.Show(@"welcome");

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
                    switch (Payload.Status)
                    {
                        case Data.Status.blank:
                            Cs_dice_1.View.Show("no blank spaces or empty strings allowed");                   
                        break;
                        case Data.Status.range_error:
                            Cs_dice_1.View.Show("must be in the range of 1-100 i.e. 1d20");                   
                        break;
                        default:
                            Cs_dice_1.View.Show("please enter a valid dice roll");
                        break;
                        
                    }
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