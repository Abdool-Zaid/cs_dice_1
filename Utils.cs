
namespace Cs_dice_1
{
    public class Utils
    {
        static public Cs_dice_1.Data<Cs_dice_1.Data<object>.Roll_input>.Packet Check_input(string inp_cmd)
        {
            Cs_dice_1.Data<Cs_dice_1.Data<object>.Roll_input>.Packet res = new();
            res.Payload = new();    // very important, do not remove 
            if (String.IsNullOrWhiteSpace(inp_cmd))
            {
                res.Status = 2;
            }
            else
            {
                res.Status = 0;

            }
            
            return res;
        }

    }
}