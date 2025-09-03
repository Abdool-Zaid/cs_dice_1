using System.Runtime.InteropServices.Marshalling;

namespace Cs_dice_1
{
    public class Math
    {
        // sum of rolls
        // roll random number
        static Cs_dice_1.Data<byte>.Packet Roll(byte max_num)
        {
            Cs_dice_1.Data<byte>.Packet res;
            var rand = new Random();
            res.Status = 0;
            res.Payload = (byte)rand.Next(1, max_num);

            return res;
        }
        public static Cs_dice_1.Data<byte[]>.Packet Roll_dice(Cs_dice_1.Data<object>.Roll_input roll_Input)
        {
            Data<byte[]>.Packet res = new()
            {
                Status = 0
                
            };

            return res;
        }
            
    }
}