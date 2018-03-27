

namespace WordPress.Framework.Factories
{
    public class PageFactory
    {
        public static T GetPage<T>() where T: new() {
          
                return new T();
        }
    }
}
