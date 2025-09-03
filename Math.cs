using System.Runtime.InteropServices.Marshalling;

namespace Cs_dice_1
{
    public class Math
    {
        // sum of rolls
        // roll random number
        static public Cs_dice_1.Data<byte>.Packet Roll(byte max_num)
        {
            Cs_dice_1.Data<byte>.Packet res;
            var rand = new Random();
            res.Status = 0;
            res.Payload = (byte)rand.Next(1, max_num);

            return res;
        }
        // coinflip enum
    }
}