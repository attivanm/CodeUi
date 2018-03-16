

namespace WordPress.Framework.Factories
{
    public class PageFactory<T> where T : new()
    {
        public static T GetPage {
            get {
                return new T();
            }

        }
    }
}
