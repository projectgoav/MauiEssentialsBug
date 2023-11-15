using Microsoft.Maui.Networking;

namespace MauiEssentialBug
{
    public class Class1
    {
        public void Foo()
        {
            var x = Connectivity.NetworkAccess;
            System.Diagnostics.Debug.WriteLine($"Foo = {x}");
        }
    }
}
