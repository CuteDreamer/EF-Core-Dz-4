using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EF_Core_Dz_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();

            //    List<User> users = new List<User>()
            //    {
            //        new User {Email = "alex@gmail.com", UserSettings = new UserSettings{ Country = "Usa", City = "Chicago"} },
            //        new User {Email = "alexmarry@gmail.com", UserSettings = new UserSettings{ Country = "Canada", City = "Toronto"} },
            //        new User { Email = "alexmarrykay@gmail.com", UserSettings = new UserSettings { Country = "Ukraine", City = "Lviv" } }
            //    };
            //    db.Users.AddRange(users);
            //    db.SaveChanges();
            //}

            using (ApplicationContext db = new ApplicationContext())
            {
                User currentUser = db.Users.Include(e => e.UserSettings).FirstOrDefault(e => e.Id == 2);
                var currentUserTwo = db.Users.Include(e => e.UserSettings).FirstOrDefault(e => e.Id == 3);
                db.Users.Remove(currentUserTwo);
                db.SaveChanges();
            }
        }
    }
}
