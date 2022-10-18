using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Real_State_Catalog.Models
{
    public class Accommodation
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Utilisateur")]
        [JsonIgnore]
        public virtual User User { get; set; }

        [Display(Name = "Adress")]
        public virtual Address Address { get; set; }

        [Required(ErrorMessage = "You must enter a name for your accommodation")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must select the housing type")]
        [Display(Name = "Type")]
        [RegularExpression("Apartment|House|Room in apartment|Room in house", ErrorMessage = "Please select a valid slot type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "You must specify the maximum number of travelers")]
        [Display(Name = "Maximum Travelers")]
        public int MaxTraveler { get; set; }
        [Required(ErrorMessage = "You must enter the description of your accommodation")]
        public string Description { get; set; }
    }
}
        