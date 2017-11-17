using Newtonsoft.Json;
using OnlineTutor.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace OnlineTutor.Module
{
    public class UserModule
    {

         private string uRL= "http://localhost:51307/api/";

        public List<User> GetAllUser()
        {
            List<User> UserVeiwModel = new List<User>();
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uRL + "/Users");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("Users").Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    UserVeiwModel = JsonConvert.DeserializeObject<List<User>>(result);
                }
                   
            }
            catch
            {
                return UserVeiwModel;
            }


            return UserVeiwModel;

        }
    }
}