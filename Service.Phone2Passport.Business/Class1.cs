using Service.Phone2Passport.DataAccess;
using Service.Phone2Passport.DataAccess.Data.Entity.SQL;

namespace Service.Phone2Passport.Business
{
    public interface IBusinessProcessor
    {
        /// <summary>
        /// Запуск процесса нормирования входящего нмоера телефона и поулчение данных из баз данных
        /// </summary>
        /// <param name="PhoneNumber">Номер телефона в любом ввиде</param>
        void Start(string PhoneNumber);
    }
     public class BusinessProcessor:IBusinessProcessor
    {
        public void Start(string PhoneNumber)
        {

            DataAccessProcessor RR = new DataAccessProcessor();
            RR.Start(); 
        }
    }
}