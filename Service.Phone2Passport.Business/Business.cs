using Service.Phone2Passport.DataAccess;
using Service.Phone2Passport.DataAccess.Data.Entity.SQL;
using Service.Phone2Passport.DataAccess.Data.Models;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Service.Phone2Passport.Business
{
    public interface IBusinessProcessor
    {
        /// <summary>
        /// Запуск процесса нормирования входящего нмоера телефона и поулчение данных из баз данных
        /// </summary>
        /// <param name="PhoneNumber">Номер телефона в любом ввиде</param>
        Task<string> Start(string PhoneNumber);

        /// <summary>
        /// Поиск по ФИО клиента и дальнейшее поулчение данных из баз данных
        /// </summary>
        /// <param name="FirstName">Фамилия</param>
        /// <param name="LastName">Имя</param>
        /// <param name="SurName">Отчество</param>
        Task<string> Start(string FirstName, string LastName,string SurName);
    }
    public class BusinessProcessor : IBusinessProcessor
    {
        Client client = new();

        public async Task<string> Start(string PhoneNumber)
        {
            client.SearchNumber = PhoneNumber;
            DataAccessProcessor DAP = new();
            client = await DAP.StartAsync(client);
            return OutClientJson(client);

        }
        public async Task<string> Start(string FirstName, string LastName, string SurName)
        {
            client.SearchSurName = SurName;
            client.SearchFirstName = FirstName;
            client.SearchLastName = LastName;

            DataAccessProcessor DAP = new();
            client = await DAP.StartAsync(client);
            return OutClientJson(client);
        }

        static string OutClientJson(Client client)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            return JsonSerializer.Serialize(client, options); 
        }
    }
}