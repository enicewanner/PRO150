﻿namespace PRO150.Models
{
    public class Card
    {
        public static int CardID;

        public static string Color;
        public static string[] colors = { "Red", "Blue", "White", "Black" };

        public static bool isAssassin = false;
        public static bool blueComplete = false;
        public static bool redComplete = false;
        public static bool whiteComplete = false;
        public static int whiteColorCount = 0;
        public static int blueColorCount = 0;
        public static int redColorCount = 0;
        public static string hintMsg;
        public static string hintedWords;

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

        public static string word1 = "";
        public static string word2;
        public static string word3;
        public static string word4;
        public static string word5;
        public static string word6;
        public static string word7;
        public static string word8;
        public static string word9;
        public static string word10;
        public static string word11;
        public static string word12;
        public static string word13;
        public static string word14;
        public static string word15;
        public static string word16;
        public static string word17;
        public static string word18;
        public static string word19;
        public static string word20;
        public static string word21;
        public static string word22;
        public static string word23;
        public static string word24;
        public static string word25;


        public static string guesserDefualtColor = "White";

        public static Random rand = new Random();

        

        public Card() { }
        public Card(int cardID, string color) { CardID = cardID; Color = color; }
        
    }
}
