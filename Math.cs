using System.Runtime.InteropServices.Marshalling;

namespace Cs_dice_1
{
    public class Math
    {
        // TODO: add sum of rolls function
        static Cs_dice_1.Data<byte>.Packet Roll(byte max_num)
        {
            Cs_dice_1.Data<byte>.Packet res;
            var rand = new Random();
            res.Status = 0;
            res.Payload = (byte)rand.Next(1, max_num+1);// need the +1 to include max_num in rolls

            return res;
        }
        public static Cs_dice_1.Data<byte[]>.Packet Roll_dice(Cs_dice_1.Data<object>.Roll_input roll_Input)
        {
            Data<byte[]>.Packet res = new();

            res.Status = 0;// TODO: add checks
            res.Payload = new byte[roll_Input.Amount_of_rolls];

            System.Console.WriteLine("length {0}", res.Payload.Length);
            for (int i = 0; i < roll_Input.Amount_of_rolls; i++)
            {
                res.Payload[i] = Roll(roll_Input.Type_of_dice).Payload;
            }   
            return res;
        }
            
    }
}