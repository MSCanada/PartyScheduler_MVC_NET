//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartyScheduler
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Party2
    {
        [Required]
        public string LoginID { get; set; }
        [Required]
        public string Password { get; set; }
        public string Title { get; set; }
        public string EventDate { get; set; }
        public string Description { get; set; }
        public string HostedBy { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public  Party2()
        {
            this.LoginID = "0";
            this.Password = "0";
            this.Title = "0";
            this.EventDate = "0";
            this.Description = "0";
            this.HostedBy = "0";
            this.ContactPhone = "0";
            this.Address = "0";
            this.Country = "0";
            this.Latitude = 0;
            this.Longitude = 0;


        }
    }
}
