using Consumo_API_CSharp.UI;

namespace Consumo_API_CSharp;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
