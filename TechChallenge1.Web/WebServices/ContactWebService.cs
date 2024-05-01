using Radzen;
using System.Net.Http.Json;
using System.Text.Json;
using TechChallenge1.Core.DTO;
using TechChallenge1.Web.WebServices.Interfaces;

namespace TechChallenge1.Web.WebServices
{
    public class ContactWebService : IContactWebService
    {
        private readonly HttpClient _httpClient;

        public ContactWebService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ContactDto?> AddContact(ContactDto contact)
        {
            var response = await _httpClient.PostAsJsonAsync("api/contacts", contact);

            if( response.IsSuccessStatusCode )
            {
                var content = await response.Content.ReadFromJsonAsync<ReturnApiDto<ContactDto>>();
                return content.Data;
            }

            return null;
        }

        public async Task<bool> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/contacts/{id}");

            if( response.IsSuccessStatusCode )
            {
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<ContactDto>> GetAll()
        {
            var response = await _httpClient.GetAsync("api/contacts");

            if( response.IsSuccessStatusCode )
            {
                if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new List<ContactDto>();
                }

                var content = await response.Content.ReadFromJsonAsync<ReturnApiDto<IEnumerable<ContactDto>>>();
                return content.Data;
            }

            var message = response.Content.ReadAsStringAsync();
            throw new Exception($"Error: {response.StatusCode} - {message.Result}");
        }

        public async Task<ContactDto?> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/contacts/{id}");

            if( response.IsSuccessStatusCode )
            {
                if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return null;
                }

                var content = await response.Content.ReadFromJsonAsync<ReturnApiDto<ContactDto>>();
                return content.Data;
            }

            var message = response.Content.ReadAsStringAsync();
            throw new Exception($"Error: {response.StatusCode} - {message.Result}");
        }

        public async Task<ReturnTableDto<ContactDto>> GetRadzenList(LoadDataArgs args)
        {
            var response = await _httpClient.PostAsJsonAsync("api/contacts/GetRadzenList", args);

            if( response.IsSuccessStatusCode )
            {
                if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new ReturnTableDto<ContactDto>();
                }

                var content = await response.Content.ReadFromJsonAsync<ReturnApiDto<ReturnTableDto<ContactDto>>>();
                return content.Data;
            }

            var message = response.Content.ReadAsStringAsync();
            throw new Exception($"Error: {response.StatusCode} - message: {message.Result}");
        }

        public async Task<ContactDto?> Update(ContactDto contact)
        {
            var response = await _httpClient.PatchAsJsonAsync("api/contacts", contact);

            if( response.IsSuccessStatusCode )
            {
                var content = await response.Content.ReadFromJsonAsync<ReturnApiDto<ContactDto>>();
                return content.Data;
            }

            var message = response.Content.ReadAsStringAsync();
            throw new Exception($"Error: {response.StatusCode} - {message.Result}");
        }
    
    }
}
