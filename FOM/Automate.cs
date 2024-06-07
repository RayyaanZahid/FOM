
namespace FOM
{
    public class Automate : BackgroundService
    {
        protected  override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Hello World");
        }
    }
}
