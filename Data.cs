namespace Cs_dice_1
{
    public class Data// will hold enums and common structs
    {
       
        public enum Coin { tail = 1, head = 2 }
        public enum Status {ok, blank, range_error}
        public struct Patterns 
        {
            public string roll;
            public string coin;
            public Patterns()
            {
                roll = @"^([1-9]|[1-9][0-9]|100)[d]([1-9]|[1-9][0-9]|100)$";
                coin = @"^([1-9]|[1-9][0-9]|100)[c]$";
            }
        } 
        public struct Roll_input
        {
            public byte Amount_of_rolls; 
            public byte Type_of_dice;
            public Roll_input()
            {
                Amount_of_rolls = 1;
                Type_of_dice = 20;
            }
        }
        public struct Packet<T>
        {
            public Data.Status Status;
            public T? Payload;

            public Packet()
            {
                Status = Status.blank;
                Payload = default;
            }
        }
    }
}