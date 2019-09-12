namespace Get_PQM_Data
{
    class Storage
    {
        private static readonly Storage sto = new Storage();
        public static Storage getStorage()
        {
            return sto;
        }
        public string name { get; set; }
        public string id { get; set; }
        public string plan_name { get; set; }
        public string plan_id { get; set; }
        public string stt_tb { get; set; }
    }
}
