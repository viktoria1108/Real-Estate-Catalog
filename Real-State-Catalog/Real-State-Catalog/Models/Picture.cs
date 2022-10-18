using System;

namespace Real_State_Catalog.Models
{
    public class Picture
    {
        public Guid Id { get; set; }

        public Guid AccommodationId { get; set; }

        public string FileName { get; set; }

        public Picture(Guid accommodationId, string fileName)
        {
            this.AccommodationId = accommodationId;
            this.FileName = fileName;
        }
    }
}
