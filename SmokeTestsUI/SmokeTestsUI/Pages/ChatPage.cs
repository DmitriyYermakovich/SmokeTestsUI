using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
    class ChatPage : BasePage
    {
        public ChatPage(IWebDriver Browser) : base(Browser)
        {

        }
        #region Locators
        By ClickPopupContainerStickersLocator = By.CssSelector(".chat-wrapper.unapproved .stickers-container l10n");
        By SendStickerLocator = By.CssSelector(".stickers-tabs-body [src='//api1.dating.lan/dialogs/stickers/hobby-002.x180']");
        By IsStickerInChatLocator = By.CssSelector(".message.sticker-container.outgoing");
        #endregion

        #region Methods
        public ChatPage ClickPopupContainerStickers()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(ClickPopupContainerStickersLocator)).Click();
            return new ChatPage(Browser);
        }

        public ChatPage SendSticker()
        {
            new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(SendStickerLocator)).Click();
            return new ChatPage(Browser);
        }

        public bool IsStickerInChatDisplayed()
        {
            return new WebDriverWait(Browser, TimeToWait)
                .Until(d => d.FindElement(IsStickerInChatLocator)).Displayed;
        }
        #endregion
    }
}

