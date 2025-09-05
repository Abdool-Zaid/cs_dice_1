using System.Runtime.Serialization;

namespace Cs_dice_1
{
     public class Program
    {
        static void Main(string[] args)
        {

            View.Show(@"welcome");

            while (true)
            {
                string? input = Console.ReadLine();
                input = string.IsNullOrWhiteSpace(input) ? "bad" : input;// pre check needed to assert not null
                var Payload = Utils.Check_input(input);
                if (input == @"/bye")
                {
                    View.Show("goodbye");
                    break;
                }
                if (Payload.Status > 0)
                {
                    switch (Payload.Status)
                    {
                        case Data.Status.blank:
                            View.Show("no blank spaces or empty strings allowed");                   
                        break;
                        case Data.Status.range_error:
                            View.Show("must be in the range of 1-100 i.e. 1d20");                   
                        break;
                        default:
                            View.Show("please enter a valid dice roll");
                        break;
                        
                    }
                }
                else
                {
                    var roll = Math.Roll_dice(Payload.Payload);
                    View.Show_all_results(roll.Payload);
                }

            }



        }
    }
}