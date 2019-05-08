using System;
using System.Threading.Tasks;

namespace task_app
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("One Moment Please...");

            var repository = new PersonRepository();
            var people = await repository.GetAsync();
            foreach(var person in people)
                Console.WriteLine(person.ToString());
        }
    }
}
