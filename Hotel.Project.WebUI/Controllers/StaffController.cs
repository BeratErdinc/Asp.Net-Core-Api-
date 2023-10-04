using Hotel.Project.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotel.Project.WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // istemcı oluşuturdlu
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:50039/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
                return View(value);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel stf)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(stf);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:50039/api/Staff", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resonsemessage = await client.DeleteAsync($"http://localhost:50039/api/Staff/{id}");
            if (resonsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var resonsemessage = await client.GetAsync($"http://localhost:50039/api/Staff/{id}");
            if (resonsemessage.IsSuccessStatusCode)
            {
                var jsondata= await resonsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateStaffViewModel>(jsondata);
                return View(values);
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel updateStaffViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateStaffViewModel);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var resonsemessage = await client.PutAsync("http://localhost:50039/api/Staff/",content);
            if (resonsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
