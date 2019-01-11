using FizzWare.NBuilder;
using PostGerarDadosFake.Model;
using System;

namespace PostGerarDadosFake
{
    class Program
    {
        static void Main(string[] args)
        {
            var Time = new TimeFutebol();

            //objeto criado com dados fakes
            Time.Codigo = Faker.RandomNumber.Next();
            Time.Nome = Faker.Name.First();
            Time.Cidade = Faker.Address.City();

            Console.WriteLine(Time.Codigo);
            Console.WriteLine(Time.Nome);
            Console.WriteLine(Time.Cidade);

            //100 objetos criados e populados com dados fakes
            var list = Builder<TimeFutebol>.CreateListOfSize(10)
                                           .All()
                                           .With(x => x.Codigo = Faker.RandomNumber.Next())
                                           .With(x => x.Nome = Faker.Name.First())
                                           .With(x => x.Cidade = Faker.Address.City())
                                           .Build();

            Console.WriteLine("");
            Console.WriteLine("Itens do objeto");
            Console.WriteLine("");

            foreach (var item in list)
            {
                Console.WriteLine(item.Codigo);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Cidade);

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}