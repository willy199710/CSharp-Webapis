namespace Webapi.Models
{
    public class account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }

    }

    public class accountParams
    {
        public string name { get; set; }
        public string? description { get; set; }

    }
}