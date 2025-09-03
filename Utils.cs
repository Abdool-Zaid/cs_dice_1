
namespace Cs_dice_1
{
    public class Utils
    {
        static public Cs_dice_1.Data<Cs_dice_1.Data<object>.Roll_input>.Packet Check_input(string inp_cmd)
        {
            Cs_dice_1.Data<Cs_dice_1.Data<object>.Roll_input>.Packet res;
            if (String.IsNullOrWhiteSpace(inp_cmd))
            {
                res.Status = 2;
            }
            else
            {
                res.Status = 0;
            }
            res.Payload.Amount_of_rolls = 1;
            res.Payload.Type_of_dice = 20;
            return res;
        }

    }
}