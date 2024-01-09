using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Data;
using System;

namespace RazorPagesLibrary.Models
{
    public class SeedAccountData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesLibraryContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesLibraryContext>>()))
            {
                if (context == null || context.AccountModel == null) 
                {
                    throw new ArgumentNullException("Null RazorPagesLibraryContext");
                }

                if(context.AccountModel.Any()) 
                {
                    return;
                }

                context.AccountModel.AddRange(
                    new AccountModel 
                    {
                         LibCardNo = "lib15123",
                         Password = "qwerty123",
                         PhoneNumber = "1234567890",
                    },
                    new AccountModel
                    {
                        LibCardNo = "lib15124",
                        Password = "asdfg123",
                        PhoneNumber = "9876543210",
                    },
                    new AccountModel
                    {
                        LibCardNo = "lib15125",
                        Password = "asdfg456",
                        PhoneNumber = "8876643310",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
