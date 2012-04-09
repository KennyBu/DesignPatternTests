using System;

namespace ConditionalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var level = new Random().Next(1, 20);

            var ninjaBuilder = NinjaBuilder
                .CreateNinjaBuilder()
                .AtLevel(level)
                .WithShurikens(10)
                .WithSkill("hideinshadows")
                    .When(() => level > 5);

            var ninja = ninjaBuilder.Build();

            Console.WriteLine("Ninja Level is: {0}", ninja.Level);
            Console.WriteLine("Ninja Skill is: {0}", !string.IsNullOrEmpty(ninja.Skill) ? ninja.Skill : "This ninja is not experienced enough for a skill.");

            Console.ReadLine();

        }
    }
}
