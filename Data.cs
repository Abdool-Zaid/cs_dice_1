namespace Cs_dice_1
{
    public class Data<T>// will hold enums and common structs
    {
        public enum Coin { tail = 0, head = 1 }
        public struct Packet
        {
           public byte Status;
            public T? Payload;

            public Packet()
            {
                Status = 1;
                Payload = default;
            }
        }
    }
}