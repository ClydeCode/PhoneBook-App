using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

internal class Database
{
    internal void Add(ContactClass Contact)
    {
        using (var db = new PhoneBookContext())
        {
            db.Contacts.Add(Contact);
            db.SaveChanges();
        }
    }

    internal void Delete(int Id)
    {
        using (var db = new PhoneBookContext())
        {
            var Contact = new ContactClass { Id = Id };

            try
            {
                db.Contacts.Remove(Contact);
                db.SaveChanges();
            } 
            catch (Exception e)
            {
                Console.WriteLine("This record doesn't exist!");
            }
        }
    }
}

