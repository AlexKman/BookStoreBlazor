using System.Collections.Generic;


namespace BookStore_API.DTOs
{
    public class AuthorDTO
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public virtual IList<BookDTO> Books { get; set; }
    }
}