using Avalonia.Controls;
using Avalonia.Input;

namespace Avalonia.Routing.App.UITests.Extensions
{
    public static class TextBoxExtensions
    {
        public static void SendText(this TextBox textBox, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            textBox.RaiseEvent(new TextInputEventArgs
            {
                Device = KeyboardDevice.Instance,
                Text = text,
                RoutedEvent = InputElement.TextInputEvent
            });
        }
    }
}
