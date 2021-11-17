using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace winuiontheweb.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new winuiontheweb.App(), args);
		host.Run();
	}
}
}
