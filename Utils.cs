
using System.Text.RegularExpressions;

namespace Cs_dice_1
{
    public class Utils
    {
        static public Cs_dice_1.Data.Packet<Cs_dice_1.Data.Roll_input> Check_input(string inp_cmd)
        {
            Cs_dice_1.Data.Packet<Cs_dice_1.Data.Roll_input> res = new();
            if (String.IsNullOrWhiteSpace(inp_cmd))
            {
                res.Status = Data.Status.blank;
                return res;
            }


            else
            {
                Cs_dice_1.Data.Patterns patterns = new();// TODO: change to switch cas to handle coin flip and more later down the line 

                Match match = Regex.Match(inp_cmd, patterns.roll);
                if (match.Success)
                {
                    res.Payload.Amount_of_rolls = Convert.ToByte(match.Groups[1].Value);
                    res.Payload.Type_of_dice = Convert.ToByte(match.Groups[2].Value);
                    res.Status = Data.Status.ok;
                }
                else
                {
                    res.Status = Data.Status.range_error;
                }

            }
            return res;
            
        }

    }
}