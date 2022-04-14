using System;

namespace ColorName
{
    class ColorChoice
    {
        public static string color_danger;
        public static string color_success;
        public static string color_info;

        static ColorChoice()
        {
            Console.WriteLine("Create Static");
            color_danger = "red";
            color_success = "green";
            color_info = "blue";

        }
    }
}