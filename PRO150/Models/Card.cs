namespace PRO150.Models
{
    public class Card
    {
        public static int CardID;

        public static string Color;
        public static string[] colors = { "Red", "Blue", "White", "Black" };

        public static bool isAssassin = false;
        public static int whiteColorCount = 0;
        public static int blueColorCount = 0;
        public static int redColorCount = 0;

        public static Random rand = new Random();

        public Card() { }
        public Card(int cardID, string color) { CardID = cardID; Color = color; }
        
    }
}
