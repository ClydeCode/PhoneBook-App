﻿using Microsoft.Data.SqlClient;
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
            catch (Exception)
            {
                Console.WriteLine("This record doesn't exist!");
            }
        }
    }

    internal void Update(ContactClass Contact)
    {
        using (var db = new PhoneBookContext())
        {
            var record = db.Contacts.Find(Contact.Id);

            if (record != null)
            {
                record.Name = Contact.Name;
                record.PhoneNumber = Contact.PhoneNumber;

                db.Contacts.Update(record);
                db.SaveChanges();
            } 
            else
            {
                Console.WriteLine("This record doesn't exist!");
            }
        }
    }

    internal ContactClass Read(int Id)
    {
        ContactClass? Record;

        using (var db = new PhoneBookContext())
        {
            
            Record = db.Contacts
                .Where(record => record.Id == Id)
                .Select(record => new ContactClass { Id = record.Id, Name = record.Name, PhoneNumber = record.PhoneNumber })
                .FirstOrDefault();
            
            if (Record == null) Console.WriteLine("This record doesn't exist!");
        }

        return Record!;
    }
}

