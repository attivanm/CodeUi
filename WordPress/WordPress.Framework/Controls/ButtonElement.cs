using WordPress.Framework.Engine;

namespace WordPress.Framework.Controls
{
    public class ButtonElement : WebElementBase
    {
        public ButtonElement() {
        }

        public ButtonElement(Locator locator, string value, string controlName)
            : base(locator, value, controlName)
        {

        }
    }
}
