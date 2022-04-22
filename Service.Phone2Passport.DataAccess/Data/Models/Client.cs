using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Phone2Passport.DataAccess.Data.Models
{
    public class Client
    {
        private string number;
        private string firstName;
        private string lastName;
        private string surName;
        /// <summary>
        /// Поисковый Номер телефона клиента
        /// </summary>
        public string SearchNumber
        {
            get
            {
                return number;
            }
            set
            {
                // ФОРМАЛИЗУЕМ номер телефона к стандартному типу
                string KK = value.ToString();
                KK = KK.Replace("+", "");
                KK = KK.Replace("(", "");
                KK = KK.Replace(")", "");
                KK = KK.Replace("-", "");
                KK = KK.Replace(".", "");
                number = KK.Trim(' ');
            }
        }
        /// <summary>
        /// Поисковое Фамилия
        /// </summary>
        public string SearchFirstName
        {
            get { return firstName; }
            set { firstName = value.ToUpper(); }
        }
        /// <summary>
        /// Поисковое Имя
        /// </summary>
        public string SearchLastName
        {
            get { return lastName; }
            set { lastName = value.ToUpper(); }
        }
        /// <summary>
        /// Поисковое Отчество
        /// </summary>
        public string SearchSurName
        {
            get { return surName; }
            set { surName = value.ToUpper(); }
        }
        //Пасспорт клиента 
        public Passport[] ?passport { get; set; }
    }
    public partial class Passport
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
