namespace Puscas_Andrei_Ioan_Laborator2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BookID { get; set; }
        public Book? Book { get; set; }
    }
}
