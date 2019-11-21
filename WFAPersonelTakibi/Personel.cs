using System;

namespace WFAPersonelTakibi
{
    public sealed class Personel : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Department Department { get; set; }
        public string ImageUrl { get; set; } = $@"{Environment.CurrentDirectory}\..\..\img\avatar.jpg";
    }
}
