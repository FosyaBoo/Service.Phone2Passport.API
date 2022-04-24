using Service.Phone2Passport.DataAccess.Data.Entity.SQL;
using Service.Phone2Passport.DataAccess.Data.Models;
using System.ComponentModel;

namespace Service.Phone2Passport.DataAccess
{
    /// <summary>
    /// Объект работы с получением даных из базы
    /// </summary>
    public class DataAccessProcessor
    {
        public Client Start(Client client)
        {
            //Здесь иницилиазируем подключение к Сиквелу для получения данных
            using (var DC = new DataContext())
            {
                if (client.SearchNumber != null)
                    client.passport = DC.GetCli4Phone.Where(x => x.Phone == client.SearchNumber).ToArray();
                else
                    client.passport = DC.GetCli4Phone.Where(x => x.Name == client.SearchFirstName && x.LastName == client.SearchLastName && x.SurName == client.SearchSurName).ToArray();

                if (client.passport == null || client.passport.Length == 0)
                {
                    client.passport = new Passport[1];
                    client.passport[0] = new Passport();
                    throw new Exception("Ошибка клиент не был найден");
                }
            }

            return client;
        }
        public async Task<Client> StartAsync(Client client)
        {
            //return await Task.Run(() => Start(client));
            try
            {
                //Здесь иницилиазируем подключение к Сиквелу для получения данных
                return await Task.Run(() => Start(client));

            }
            catch (Exception ex)
            {
                client.ErrorDescription = ex.Message;
                return client;
            }

        }
    }
}