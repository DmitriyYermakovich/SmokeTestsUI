using NUnit.Framework;
using Tests.Pages;

namespace Tests
{
    public class SmokeTests : BaseTest
    {
        [Test]
        public void AuthorizationUserTest()
        {
            new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .YourEmailField()
            .PasswordField()
            .SignInBtn()
            .SandwichInPopup()
            .MenuProfile();

            Assert.That(Browser.Url,
                Does.Contain("https://www.dating.com/people/#14043278542"), "Id авторизованного клиента неверный");
        }
        [Test]
        public void RegistrationUser()
        {
            new MainPage(Browser)
                .ClickSignInWithEmailBtn()
                .ClickCreateYourAccountBtn()
                .NameOrNicknameField()
                .ReadEmailField()
                .NewPasswordField()
                .CreateAccountBtn()
                .IconMal()
                .IconFem()
                .Month();
        }
    }
}