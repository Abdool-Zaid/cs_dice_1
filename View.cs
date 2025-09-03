namespace Cs_dice_1
{
    public class View
    {
        public static void Show(string display_value)
        {
            System.Console.WriteLine(display_value);
        }
        public static void Show_all_results(byte[] roll_values)
        {
            var total = 0;
            for (int i = 0; i < roll_values.Length; i++)
            {
                total += roll_values[i];
                System.Console.WriteLine("roll {0} : {1}", i+ 1, roll_values[i]);
            }
            System.Console.WriteLine("total : {0}", total);
        }
    }
}