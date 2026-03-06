using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.MessageDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultMessageDto>>("Messages");
            return View(values);
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _client.DeleteAsync($"Messages/{id}");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
        {
            await _client.PostAsJsonAsync("Messages", createMessageDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateMessage(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateMessageDto>($"Messages/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            await _client.PutAsJsonAsync("Messages", updateMessageDto);
            return RedirectToAction(nameof(Index));

        }
    }
}
