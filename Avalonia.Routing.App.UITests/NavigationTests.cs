using Avalonia.Routing.App.UITests.Common;
using Avalonia.Routing.App.UITests.Conditions;
using Avalonia.Routing.App.UITests.Steps;

namespace Avalonia.Routing.App.UITests
{
    public class NavigationTests
    {
        [Fact]
        public async void ShouldNavigateToTabView()
        {
            var window = AvaloniaApp.GetMainWindow();
            await UploadSteps.GotoWizardView(window);
            var isUploadView = await NavigationCondition.CheckIfNavigatedToTabViewAsync(window);
            Assert.True(isUploadView);
        }
    }
}