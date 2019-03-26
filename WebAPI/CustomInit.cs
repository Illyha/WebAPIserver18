using System.Data.Entity;

namespace WebAPI
{
    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Factory>
    {
        protected override void Seed(Factory context)
        {
            base.Seed(context);

            context.Workers.Add(new Worker {
                FirstName = "Oleksiy",
                LastName = "Petrovich",
                Age = 65,
                Salary=13000m
            });

            context.Workers.Add(new Worker
            {
                FirstName = "Ivan",
                LastName = "Ivanovich",
                Age = 43,
                Salary = 90000m
            });

            context.Workers.Add(new Worker
            {
                FirstName = "Petro",
                LastName = "Oleksiyovich",
                Age = 50,
                Salary = 52000m
            });

            context.SaveChanges();
        }
    }
}