namespace CDN___MadeInTJ
{
    public static class Items
    {
        static Random rand = new Random();
        public static int GetWeapon()
        {
            return rand.Next(10, 101);
        }
        public static int GetArmor()
        {
            return rand.Next(10, 101);
        }
        public static int GetHelmet()
        {
            return rand.Next(10, 101);
        }
        public static int GetPosion()
        {
            return rand.Next(10, 101);
        }

    }
}