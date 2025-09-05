namespace Cs_dice_1
{
    public class Data// will hold enums and common structs
    {
       
        public enum Coin { tail = 0, head = 1 }
        public enum Status {ok, blank, range_error}
        public struct Patterns
        {
            public string roll;
            public Patterns()
            {
                roll = @"^([1-9]|[1-9][0-9]|100)[d]([1-9]|[1-9][0-9]|100)$";
            }
        } 
        public struct Roll_input
        {
            public byte Amount_of_rolls; // want to limit this to 1 - 100
            public byte Type_of_dice; // same as above
            public Roll_input()
            {
                Amount_of_rolls = 1;
                Type_of_dice = 20;
            }
        }
        public struct Packet<T>
        {
            public Cs_dice_1.Data.Status Status;
            public T? Payload;

            public Packet()
            {
                Status = Status.ok;
                Payload = default;
            }
        }
    }
}