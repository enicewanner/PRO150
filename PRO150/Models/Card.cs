using PRO150.Controllers;

namespace PRO150.Models
{
    public class Card
    {
        public static int CardID;

        public static string Color;
        public static string[] colors = { "Red", "Blue", "White", "Black" };




        public static string guesserDefualtColor = "White";
        public static string tempHintMsg;
        public static string tempHintCount;
        public static bool isClicked = false;

        public static bool isAssassin = false;
        public static bool blueComplete = false;
        public static bool redComplete = false;
        public static bool whiteComplete = false;
        public static int whiteColorCount = 0;
        public static int blueColorCount = 0;
        public static int redColorCount = 0;
        public static string hintMsg;
        public static int hintedWords;

        public static string color1;
        public static string color2;
        public static string color3;
        public static string color4;
        public static string color5;
        public static string color6;
        public static string color7;
        public static string color8;
        public static string color9;
        public static string color10;
        public static string color11;
        public static string color12;
        public static string color13;
        public static string color14;
        public static string color15;
        public static string color16;
        public static string color17;
        public static string color18;
        public static string color19;
        public static string color20;
        public static string color21;
        public static string color22;
        public static string color23;
        public static string color24;
        public static string color25;
       
       

        public static Random rand = new Random();

        public Card() { }
        public Card(int cardID, string color) { CardID = cardID; Color = color; }

        
        
    }
}
