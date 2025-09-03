
using System.Text.RegularExpressions;

namespace Cs_dice_1
{
    public class Utils
    {
        static public Cs_dice_1.Data.Packet<Cs_dice_1.Data.Roll_input> Check_input(string inp_cmd)
        {
            Cs_dice_1.Data.Packet<Cs_dice_1.Data.Roll_input> res = new();
            res.Payload = new();    // very important, do not remove 
            if (String.IsNullOrWhiteSpace(inp_cmd))
            {
                res.Status = 2;
            }
            else
            {
                Cs_dice_1.Data.Patterns patterns = new();

                bool is_match = Regex.IsMatch(inp_cmd, patterns.roll);
                if (is_match)
                {
                    
                    res.Status = 0;
                }
                else
                {
                    res.Status = 3;
                }

            }
            
            return res;
        }

    }
}