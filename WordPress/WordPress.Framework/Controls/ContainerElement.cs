using WordPress.Framework.Engine;

namespace WordPress.Framework.Controls
{
    public class ContainerElement : WebElementBase
    {
        public ContainerElement()
        {

        }
        public ContainerElement(Locator locator, string value, string controlName)
            : base(locator, value, controlName)
        {

        }
    }
}
