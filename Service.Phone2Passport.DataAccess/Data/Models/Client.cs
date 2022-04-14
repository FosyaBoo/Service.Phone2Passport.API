using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Phone2Passport.DataAccess.Data.Models
{
    public partial class Client
    {
        [Key]
        public System.Guid idCli { get; set; }
        public string? Phone { get; set; }
        public string? PhoneFormatted { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public string? Building { get; set; }
        public string? Apartment { get; set; }
        public string? Address { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? SurName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string? BirthPlace { get; set; }
        public string? Resident { get; set; }
        public string? IDtype { get; set; }
        public string? IDnumber { get; set; }
        public string? IDwhom { get; set; }
        public string? IDwhomCode { get; set; }
        public DateTime? IDdate { get; set; }
        public string ?IDtypeCode { get; set; }
        public string ?LockedDescription { get; set; }
        public Nullable<bool> Locked { get; set; }
    }
}
