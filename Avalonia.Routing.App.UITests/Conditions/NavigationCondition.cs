using Avalonia.Controls;
using Avalonia.Routing.App.UITests.Common;
using Avalonia.VisualTree;

namespace Avalonia.Routing.App.UITests.Conditions
{
    public static class NavigationCondition
    {
        public static Task<bool> CheckIfNavigatedToTabViewAsync(Window mainWindow) =>
            WaitService.WaitForConditionAsync(() => CheckIfNavigatedToTabView(mainWindow));

        private static bool CheckIfNavigatedToTabView(Window mainWindow) =>
             mainWindow
            .GetVisualDescendants()
            .OfType<TabControl>()
                .Any();
    }
}
