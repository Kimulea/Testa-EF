using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testa_EF.Interfaces;
using Testa_EF.Models;
using Testa_EF.Services;

namespace Testa_EF
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();
            IGenericRepository<User> repository = new GenericRepository<User>(context);
            IGenericRepository<Availability> repository1 = new GenericRepository<Availability>(context);

            // CRUD FOR USERS

            //Find user by id
            /*User user = (User)await repository.GetById(102);

            Console.WriteLine(user.Name);*/

            //CREATE
            /*var user = new VipUser()
            {
                Bonus = 3
            };

            await repository.Add(user);*/

            //READ
            /*var users = await repository.GetAll();
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }*/

            //UPDATE
            /*var user = new User()
            {
                Id = 101,
                Name = "Vadim Chim",
                BirthDate = new DateTime(2000, 12, 20)
            };
            await repository.Update(user);*/

            //DELETE
            /*var user = new User()
            {
                Id = 101,
                Name = "Vadim Chim",
                BirthDate = new DateTime(2000, 12, 20)
            };
            await repository.Remove(user);*/

            //READ WITH CONDITION
            /*IEnumerable<User> users = (IEnumerable < User > ) await repository.GetWhere(x => x.Id > 5);

            foreach (User item in users)
            {
                Console.WriteLine(item.Name);
            }*/

            // END CRUD FOR USERS

            //Concurency EXCEPTION

            /*try
            {
                using var context2 = new AppDbContext();
                IGenericRepository<User> repository2 = new GenericRepository<User>(context2);

                User user1 = await repository.GetById(1);
                User user2 = await repository2.GetById(1);

                user1.Name = "aboba";
                user2.Name = "abobus";

                await repository.Update(user1);
                await repository2.Update(user2);
            }
            catch (DbUpdateConcurrencyException e)
            {

            }*/

            //CASCADE SAVE, UPDATE, DELETE

            //SAVE
            /*var user = new User()
            {
                Name = "Gheorghe"
            };

            user.Availabilities = new List<Availability>();

            for (int i = 0; i < 3; i++)
            {
                var freeHour = new Availability()
                {
                    Hour = i * 4 + 1,
                    Minute = 0,
                    DayOfWeek = 1,
                    User = user
                };

                user.Availabilities.Add(freeHour);
            }

            await repository.Add(user);*/

            //DELETE
            /*var user = await repository.GetById(105);

            await repository.Remove(user);*/

            //UPDATE
            /*var user = await repository.GetById(105);

            user.Name = "Gheorghe updated";

            foreach (var item in user.Availabilities)
            {
                item.Hour--;
            }

            await repository.Update(user);*/

            /*var query = from availabilities in context.Availabilities
                        group availabilities by availabilities.UserId into a
                        select new
                        {
                            Count = a.Count()
                        };*/

            /*var query = from availabilities in context.Availabilities
                        join users in context.Users
                            on availabilities.UserId equals users.Id
                        group new { availabilities, users} by 
                        new { 
                            UserId = availabilities.UserId,
                            UserName = users.Name
                        } into a
                        select new
                        {
                            UserName = a.Key.UserName,
                            Max = a.Max(x => x.availabilities.Hour),
                            Count = a.Count()
                        };*/

            // left join
            /*var query = from availabilities in context.Availabilities
                        join users in context.Users
                            on availabilities.UserId equals users.Id
                        where availabilities.DayOfWeek < 6
                        group new { availabilities, users } by
                        new
                        {
                            UserId = availabilities.UserId,
                            UserName = users.Name
                        } into a
                        where EF.Functions.Like(a.Key.UserName, "a%")
                        select new
                        {
                            UserName = a.Key.UserName,
                            Max = a.Max(x => x.availabilities.Hour),
                            Count = a.Count()
                        };*/

            //cross join
            /*var query = from availabilities in context.Availabilities
                        from users in context.Users
                        select new
                        {
                            availabilities,
                            users
                        };*/

            //inner join
            /*var query = from availabilities in context.Availabilities
                        from users in context.Users.Where(x => x.Id == availabilities.UserId)
                        select new
                        {
                            availabilities,
                            users
                        };*/

            /*var query = from availabilities in context.Availabilities
                        from users in context.Users.Select(x => x.Name + " " + availabilities.DayOfWeek)
                        select new
                        {
                            availabilities,
                            users
                        };*/

            /*var query = from users in context.Users
                        select new
                        {
                            hour = users.Availabilities.Any() ? users.Availabilities.DefaultIfEmpty().Average(r => r.Hour) : 0
                        };

            var result = query.ToList();*/



            /*foreach (var item in result)
            {
                Console.WriteLine(item.Count);
            }*/

            // PREGATIRE EXMAEN

            /*var result = context.Users.Join(context.Availabilities,
                u => u.Id,
                a => a.UserId,
                (u, a) => new { user = u, availability = a }).ToList();*/

            /*var result = context.Users.SelectMany(x => x.Availabilities, (b, r) => new
            {
                name = b.Name,
                hour = r.Hour
            }).ToList();*/


        }
    }
}
