using Avalonia.Input;
using Avalonia.Routing.App.UITests.Common;
using Avalonia.Routing.App.Views;

namespace Avalonia.Routing.App.UITests.Steps
{
    public static class UploadSteps
    {
        public static async Task GotoWizardView(MainWindow window)
        {
            await Task.Delay(100);

            Keyboard.PressKey(window, Key.Tab);
            Keyboard.PressKey(window, Key.Enter);
        }
    }
}
