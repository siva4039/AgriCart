using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
       public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
       {
           if(!userManager.Users.Any())
           {
               var user = new AppUser
               {
                   DisplayName = "Siva",
                   Email = "siva@agricart.com",
                   UserName ="siva@agricart.com",
                   Address = new Address
                   {
                       FirstName = "Siva",
                       LastName = "Martha",
                       Street = "Mylavaram",
                       Village = "Mylavaram",
                       City = "Ongole",
                       State = "Andhra Pradesh",
                       Zipcode = "523226"
                      
                   }
               };
               await userManager.CreateAsync(user, "S!v@4039");
           }
       }
    }
}