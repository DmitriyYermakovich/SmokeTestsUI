using NUnit.Framework;
using Tests.Pages;
using Helper;
using AnyPage;

namespace Tests
{

    public class SmokeTests : BaseTest
     {
    [Test]
    public void AuthorizationUserTest()
    {
        var email = "dcUMT_1581089986812_test@dating.com";
        var password = "654321";

        new MainPage(Browser)
          .ClickSignInWithEmailBtn()
          .TypingYourEmailField(email)
          .TypingPasswordField(password)
          .ClickSignInBtn();

        new BluredPage(Browser)
           .ClickSandwichInPopup()
           .ClickMenuProfile();

             var UserId = "14043278542";
             Assert.That(Browser.Url, Does.Contain(UserId), "Id авторизованного клиента неверный");
         }

    [Test]
    public void SingInFailedWithEmptyGenderAndDateOfBirthTest()
    {
         new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .ClickCreateYourAccountBtn()
            .TypingNameOrNicknameField()
            .TypingReadEmailField()
            .TypingNewPasswordField()
            .ClickCreateAccountBtn()
            .ClickNextBtn();

             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextYouGenderOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для поля выбора пола");
             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextYouGenderOnAboutYouForm(), Does.Contain("Select your gender"), "Неправильная подсказка для поля выбора пола");

             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextGenderPreferenceOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для поля выбора предпочитаемого пола");
             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextGenderPreferenceOnAboutYouForm(), Does.Contain("Select gender preference"), "Неправильная подсказка для поля выбора предпочитаемого пола");

             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextDateOfBirthOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для полей указания дня рождения");
             Assert.That(new AboutYouFormPage(Browser).IsInvalidTextDateOfBirthOnAboutYouForm(), Does.Contain("Select your date of birth"), "Неправильная подсказка для полей указания дня рождения");
         }

    [Test]
     public void RegistrationUserTest()
     {
            new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .ClickCreateYourAccountBtn()
            .TypingNameOrNicknameField()
            .TypingReadEmailField()
            .TypingNewPasswordField()
            .ClickCreateAccountBtn()
            .SelectMonthOfBirth()
            .SelectDayOfBirth()
            .SelectYearOfBirth()
            .SelectOwnGenderMal()
            .SelectPrefferedGenderFemale()
            .ClickNextBtn()
            .ClickApproveBigBtn()
            .ClickApproveBigTwoBtn()
            .ClickApproveBitBtn()
            .ClickPhotosFormApproveBtn();

            Assert.That(new BluredPage(Browser).ClickPopupControlUnknownDisplayed(), Is.True, "Не отображается блок для выбора настроения");
        }

        [Test]
        public void FirstPurchaseCreditsTest()
        {
            new RegistrationTestUser(Browser)
            .RegistrationNewTestUser();

            new PurchaseCredits(Browser)
            .PurchaseCreditsClient();

            Assert.That(new PeoplePage(Browser).BtnRefillAccountDisplayed(), Is.True, "Отсутствует кнопка 'Refill account'");
            Assert.That(new BluredPage(Browser).IsNoticePurchasedCreditsDisplayed(), Is.True, "Не отобразилось уведомление о покупке 150 кредитов");
            Assert.That(new BluredPage(Browser).IsNoticePurchaseMembershipDisplayed(), Is.True, "Не отобразилось уведомление о покупке МШ");

            new BluredPage(Browser)
            .ClickSandwichInPopup()
            .ClickMenuProfile();

            Assert.That(new PeoplePage(Browser).IsTo150CreditsAfterPurchase(), Is.True, "Не начислены 150 кредитов");
        }

        [Test]
        public void ChatBetweenTwoClientsTest()
        {
            //var email = "dcUMT_1594806517014_test@dating.com";
            //var password = "sdvtest123";
            //var usertestid = "90931860031";

            //new MainPage(Browser)
             // .ClickSignInWithEmailBtn()
              //.TypingYourEmailField(email)
              //.TypingPasswordField(password)
              //.ClickSignInBtn();

            //new BluredPage(Browser)
           //    .GoToUserProfilePage(usertestid);
           // new ProfilePage(Browser).ClickChatNowBtn();
           // new ChatPage(Browser)
            //.ClickPopupContainerStickers();

            new RegistrationTestUser(Browser).RegistrationNewTestUser();
            new PurchaseCredits(Browser).PurchaseCreditsClient();
            new BluredPage(Browser).ClickSandwichInPopup();
            
            var usersId = new ProfilePage(Browser).GetUserId();

            new RegistrationTestUser(BrowserTwo).RegistrationNewTestUser();
            new PurchaseCredits(BrowserTwo).PurchaseCreditsClient();
            new BluredPage(BrowserTwo)
                .ClickSandwichInPopup()
                .ClickMenuProfile()
                .GoToUserProfilePage(usersId);
            new ProfilePage(BrowserTwo).ClickChatNowBtn();
            new ChatPage(BrowserTwo)
            .ClickPopupContainerStickers()
            .SendSticker();

            Assert.That(new ChatPage(BrowserTwo).IsStickerInChatDisplayed(), Is.True, "Стикер не отправлен в чат с другим клиентом");

            new ChatPage(Browser).ClickMyContacts();
            Assert.That(new ChatPage(Browser).IsStickerInChaInterlocutortDisplayed(), Is.True, "Стикер не появился в чате от клиента");
        }
    }
}
