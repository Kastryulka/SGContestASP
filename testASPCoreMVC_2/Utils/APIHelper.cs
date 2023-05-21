using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace testASPCoreMVC_2.Utils
{
    public class APIHelper
    {
        //static HttpClient httpClient = new HttpClient();
        public string _getUserInfoEndpoint = "http://localhost:57888/api/get_user_info";
        public string _getCoursesDataEndpoint = "http://localhost:57888/api/get_courses_data";

        public async Task<String> getUsersAsync() {
            string json = JsonConvert.SerializeObject(new { user_name = "*" });
            return sendPost(_getUserInfoEndpoint, json);
        }

        public async Task<String> getOneUserAsync(string userName){
            string json = JsonConvert.SerializeObject(new { user_name = userName });
            return sendPost(_getUserInfoEndpoint, json);
        }

        public async Task<String> getProblemsAsync(){
            string json = JsonConvert.SerializeObject(new { id = 1, mqtt_key = "234", user = "2321", type = "problems", data_key = "test", action = "get_data" });
            return sendPost(_getCoursesDataEndpoint, json);
        }

        /*public static async Task<HttpResponseMessage> getProblemsAsync()
        {
            // создаем JsonContent
            JsonContent content = JsonContent.Create(new UserModel { user_name = "*" });
            // отправляем запрос
            using var response = await httpClient.PostAsync("http://localhost:57888/api/get_user_info", content);
            Console.WriteLine(response);
            return response;
        }*/

        public string? sendPost(string endpoint, string json) {
            byte[] body = Encoding.UTF8.GetBytes(json);
            Console.WriteLine("post: " + json);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.ContentLength = body.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(body, 0, body.Length);
                stream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using var reader = new StreamReader(response.GetResponseStream());
            string content = reader.ReadToEnd();

            Console.WriteLine("ответ: " + content);
            return content;
        }
    }
}
