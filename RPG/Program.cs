using StructureMap;

namespace RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = Container.For<ConsoleRegistry>();
            var app = container.GetInstance<Application>();

            app.Run();
        }
    }
}
