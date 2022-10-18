using System;
using System.ComponentModel.DataAnnotations;

namespace Real_State_Catalog.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        public int AccommodationId { get; set; }

        public string FileName { get; set; }

        public Picture(int accommodationId, string fileName)
        {
            this.AccommodationId = accommodationId;
            this.FileName = fileName;
        }
    }
}
