using System;
using System.Collections.Generic;

namespace PC_QRCodeSystem.Model
{
    public static class UserData
    {
        public static string dept { get; set; }
        public static string position { get; set; }
        public static string usercode { get; set; }
        public static string username { get; set; }
        public static double onTime { get; set; }
        public static bool isOnline { get; set; }
        public static DateTime logintime { get; set; }
        public static List<string> role_permision { get; set; }
    }
}
