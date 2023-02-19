namespace PRO150.Models
{
    public class Card
    {
        public static int[] CardID = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

        public static string[] colors = { "Red", "Blue", "White", "Black" };

        public static bool isAssassin = false;
        public static bool blueComplete = false;
        public static bool redComplete = false;
        public static bool whiteComplete = false;
        public static int whiteColorCount = 0;
        public static int blueColorCount = 0;
        public static int redColorCount = 0;

        public static Random rand = new Random();

        
    }
}
