using Service.Phone2Passport.DataAccess.Data.Entity.SQL;

namespace Service.Phone2Passport.DataAccess
{
    public class DataAccessProcessor
    {
        public void Start()
        {
            using (var db1 = new DataContext())
            {
                var dfdf = db1.GetCli4Phone.Where(x => x.Phone == "9407000440").FirstOrDefault();
                if (dfdf != null)
                {
                    int a = 0;
                }
            }
        }

    }
}