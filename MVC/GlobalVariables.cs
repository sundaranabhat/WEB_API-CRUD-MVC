using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVC
{
    public static class GlobalVariables
    {
        //creating the HttpClient Object and now we can use the this webApi object through out the life Cycle if the Application
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:53366/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}
