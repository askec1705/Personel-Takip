using System;

namespace WFAPersonelTakibi
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIp = "127.0.0.1";
            this.Id = Guid.NewGuid(); //otomatik olarak yeni id üretsin diye
        }


        public Guid Id { get; set; } //int yönetimi listede zor olabileceğinden guid hale getirdik
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
    }
}
