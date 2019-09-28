namespace EndplayCheck
{
    class Storage
    {
        private static readonly Storage sto = new Storage();
        public static Storage getStorage()
        {
            return sto;
        }
        public string server { get; set; }
        public string database { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
    }
}