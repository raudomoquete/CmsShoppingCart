using CmsShoppingCart.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CmsShoppingCartContext
                (serviceProvider.GetRequiredService<DbContextOptions<CmsShoppingCartContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }

                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content = "home Page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Title = "About Us",
                        Slug = "about-us",
                        Content = "about us Page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "services Page",
                        Sorting = 100
                    },
                      new Page
                      {
                          Title = "Contact",
                          Slug = "contact",
                          Content = "contact Page",
                          Sorting = 100
                      });
                context.SaveChanges();
            }
        }
    }
}
