using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;
using OnlineEdu.WebUI.DTOs.BlogDtos;
using OnlineEdu.WebUI.Helpers;
using OnlineEdu.WebUI.Validators;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task CategoryDropDown()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogcategories");
            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.BlogCategoryId.ToString()

                                               }).ToList();
            ViewBag.categories = categories;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogDto>>("Blogs");
            return View(values);
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _client.DeleteAsync($"Blogs/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateBlog()
        {
            await CategoryDropDown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            var validator = new BlogValidator();
            var result = await validator.ValidateAsync(createBlogDto);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
            await _client.PostAsJsonAsync("Blogs", createBlogDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateBlog(int id)
        {
            await CategoryDropDown();
            var values = await _client.GetFromJsonAsync<UpdateBlogDto>($"Blogs/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            await _client.PutAsJsonAsync("Blogs", updateBlogDto);
            return RedirectToAction(nameof(Index));

        }
    }
}
