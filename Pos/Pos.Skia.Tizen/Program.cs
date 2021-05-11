using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Pos.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Pos.App(), args);
            host.Run();
        }
    }
}
