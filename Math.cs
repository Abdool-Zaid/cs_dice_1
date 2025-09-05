using System.Runtime.InteropServices.Marshalling;

namespace Cs_dice_1
{
    public class Math
    {
        // TODO: add sum of rolls function
        static Data.Packet<byte> Roll(byte max_num)
        {
            Data.Packet<byte> res;
            var rand = new Random();
            res.Status = Data.Status.ok;
            res.Payload = (byte)rand.Next(1, max_num+1);// need the +1 to include max_num in rolls

            return res;
        }
        static Data.Packet<Data.Coin> Coin_flip()
        {
            Data.Packet<Data.Coin> res = new();
            var rand = new Random();
            res.Status = Data.Status.ok;
            res.Payload = (Data.Coin)rand.Next(1,2);
            return res;
        }
        public static Data.Packet<byte[]> Roll_dice(Data.Roll_input roll_Input)
        {
            Data.Packet<byte[]> res = new();

            res.Status = Data.Status.ok;// TODO: add checks
            res.Payload = new byte[roll_Input.Amount_of_rolls];
            for (int i = 0; i < roll_Input.Amount_of_rolls; i++)
            {
                res.Payload[i] = Roll(roll_Input.Type_of_dice).Payload;
            }
            return res;
        }
            
    }
}