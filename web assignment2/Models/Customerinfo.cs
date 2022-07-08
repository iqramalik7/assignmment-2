using System.ComponentModel.DataAnnotations;

namespace web_assignment2.Models
{
    public class Customerinfo
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string gender { get; set; }
        public string dep { get; set; }
        public string message { get; set; }
    }
}
