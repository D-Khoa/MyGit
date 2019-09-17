using System.Data;

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
        public DataTable table { get; set; }
    }
}
