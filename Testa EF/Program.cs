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

            // CRUD FOR USERS

            //Find user by id
            /*User user = (User)await repository.GetById(102);

            Console.WriteLine(user.Name);*/

            //CREATE
            /*var user = new User()
            {
                Name = "Volodea",
                BirthDate = new DateTime(2000, 12, 20)
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

            // END CRUD FOR USERS

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
                        };
*/
            //var result = query.ToList();



            /*foreach (var item in result)
            {
                Console.WriteLine(item.Count);
            }*/
        }
    }
}
