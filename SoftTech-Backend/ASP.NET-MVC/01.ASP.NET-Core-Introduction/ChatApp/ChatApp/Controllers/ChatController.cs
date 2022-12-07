using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string, string>> Messages = new();
        
        public IActionResult Show()
        {
            if (Messages.Count() < 1)
                return View(new ChatViewModel());
            
            ChatViewModel chatModel = new()
            {
                // Ensuring that Messages is a collection of MessageViewModel
                Messages = Messages.Select(m => new MessageViewModel
                {
                    Sender = m.Key,
                    MessageText = m.Value
                }).ToList()
            }; 
            return View(chatModel);
        }
        
        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            MessageViewModel message = chat.CurrentMessage;

            Messages.Add(new KeyValuePair<string, string>(message.Sender, message.MessageText));

            return RedirectToAction("Show");
        }
    }
}
