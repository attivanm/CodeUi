
using OpenQA.Selenium;
using WordPress.Framework.Browser;

namespace WordPress.Framework.Pages
{
    public class LoginPage
    {
        public static void GoTo() {
            BrowserManager.Instance.GoTo();
        }

        public static LoginPageCommand LoginAs(string userName) {
            return new LoginPageCommand(userName);
        }
    }

    public class LoginPageCommand
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginPageCommand(string userName)
        {
            UserName = userName;
        }

        public LoginPageCommand WithPassword(string password) {
            Password = password;
            return this;
        }

        public void Login() {
            BrowserManager.Instance.Driver
                .FindElement(By.Id("user_login")).SendKeys(UserName);

            BrowserManager.Instance.Driver
                .FindElement(By.Id("user_pass")).SendKeys(Password);

            BrowserManager.Instance.Driver
                .FindElement(By.Id("wp-submit")).Click();

        }
    }
}
