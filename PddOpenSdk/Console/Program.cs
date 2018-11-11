using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var helper = new PddApiDocHelper();
            for (int i = 5 ; i < 6; i++)
            {
                await helper.GetDocListByCatAsync(i);
            }

            System.Console.WriteLine("finish");
            System.Console.ReadLine();

        }
    }
}