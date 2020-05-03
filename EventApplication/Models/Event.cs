using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Enter a Title for the Event")]
        [MaxLength(50, ErrorMessage = "Allowable max is 50 letters")]
        public virtual string EventTitle { get; set; }


        [StringLength(150, ErrorMessage = "Cannot be over 150 characters")]
        public virtual string EventDescription { get; set; }


        [Required(ErrorMessage = "Start date cannot be in the past")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0;MMdd/yyyy")]
        public virtual string EventStartDate { get; set; }


        [Required(ErrorMessage = "End date cannot be before the start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0;MMdd/yyyy")]
        public virtual string EventEndDate { get; set; }


        [Required(ErrorMessage = "Enter a location")]
        public virtual string EventLocation { get; set; }


        [Required(ErrorMessage = "Enter your name")]
        public virtual string OrganizerName { get; set; }
        public virtual string OrganizerContactInfo { get; set; }

        [Required(ErrorMessage = "Must be more than 0")]
        public virtual int MaxTickets { get; set; }

        [Required(ErrorMessage = "Must be more than 0")]
        public virtual int AvailableTickets { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
    }
}