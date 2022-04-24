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
        /// Поиск по ФИО клиента и дальнейшее поулчение данных из баз данных
        /// </summary>
        /// <param name="FirstName">Фамилия</param>
        /// <param name="LastName">Имя</param>
        /// <param name="SurName">Отчество</param>
        Task<string> Start(string PhoneNumber, string FirstName, string LastName,string SurName);
    }
    public class BusinessProcessor : IBusinessProcessor
    {
        Client client = new();

        public async Task<string> Start(string PhoneNumber,string FirstName, string LastName, string SurName)
        {
            client.SearchNumber = PhoneNumber;
            client.SearchSurName = SurName;
            client.SearchFirstName = FirstName;
            client.SearchLastName = LastName;

            DataAccessProcessor DAP = new();
            Client Cli = await DAP.StartAsync(client);
            return OutClientJson(Cli);
        }

        static string OutClientJson(Client objectClass)
        {
            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            return JsonSerializer.Serialize(objectClass, options); 
        }
    }
}