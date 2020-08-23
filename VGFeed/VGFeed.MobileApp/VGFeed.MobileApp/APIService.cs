using Flurl.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VGFeed.Model;
using Xamarin.Forms;

namespace VGFeed.MobileApp
{
    public class APIService
    {
        private readonly string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int KorisnikId { get; set; }
#if DEBUG
        string _APIUrl = "http://localhost:5000/api";
#endif
#if RELEASE
        string _APIUrl = "https://linktoapi.com/api";
#endif
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> GetSlicni<T>(int id)
        {
            var url = $"{_APIUrl}/{_route}/GetSlicni/{id}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_APIUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch(FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste authentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešan username ili password", "OK");
                }
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            
                var url = $"{_APIUrl}/{_route}/{id}";
            try
            {
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_APIUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {

            var url = $"{_APIUrl}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Authenticate<T>(object username, object password)
        {
            var url = $"{_APIUrl}/{_route}/{username}:{password}";
            try
            {
                var result= await url.PostJsonAsync(null).ReceiveJson<T>();
                if (result == null)
                {
                   await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešan username ili password", "OK");
                    return default(T);
                }
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
    }
}
