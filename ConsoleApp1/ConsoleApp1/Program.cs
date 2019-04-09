using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<EFContext>()
                       .UseInMemoryDatabase("test")
                       .Options;

            var ctx = new EFContext(options);
            ctx.Models.Add(new Model(StateEnum.State1, "Name1"));
            ctx.Models.Add(new Model(StateEnum.State2, "Name2"));
            ctx.SaveChanges();

            var models = ctx.Models.ToListAsync().Result;
            models.ForEach(model =>
            {
                Console.WriteLine($"Found entity {model.Id} with name {model.Text} and state {model.State}");
            });


            Console.Read();

       
        }
    }
}
