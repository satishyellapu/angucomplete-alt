using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using LeftOverFeast.Model;
using System.Collections.Generic;

namespace LeftOverFeast.APICall
{
    public class ApiCalls
    {
        //private static string AFMAPI = "http://aftermarketapi.plexif.com/api/";
        public static ResponseModel Get(string url)
        {
            ResponseModel responseStatus = GetResponse(url, type: "GET");
            return responseStatus;
        }
        public static ResponseModel Post<T>(string url, T content,  HttpContent httpContent=null)
        {
            var contents = JsonConvert.SerializeObject(content);
            ResponseModel responseStatus = GetResponse(url,contents, "POST",httpContent:httpContent);
            return responseStatus;
        }
        public static ResponseModel Put<T>(string url, T content)
        {
            var contents = JsonConvert.SerializeObject(content);
            ResponseModel responseStatus = GetResponse(url, contents, "PUT");
            return responseStatus;
        }
        public static ResponseModel Delete(string url)
        {
            ResponseModel responseStatus = GetResponse(url, type: "DELETE");
            return responseStatus;
        }
        internal static ResponseModel GetResponse(string url, string content = "", string type = "", HttpContent httpContent = null)
        {
            ResponseModel responseStatus = new ResponseModel();
           
            try
            {
               
               

                HttpClient client = new HttpClient();
                HttpResponseMessage response = new HttpResponseMessage();
                // client.BaseAddress = new Uri(AFMAPI);
                client.DefaultRequestHeaders.Accept.Clear();
               
                client.DefaultRequestHeaders.Add("AuthenticationToken","AFM");
                

                // client.DefaultRequestHeaders.Add("Partno", "PlXYS4d+mHXsa8ap4wHYceKI7etS97sF2kyCCuz6GOc="); 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var requestContent = httpContent!=null?httpContent:new StringContent(content, Encoding.UTF8, "application/json");
                switch (type.ToUpper())
                {
                    case "GET":
                        response = client.GetAsync(url).Result;
                        break;
                    case "POST":
                        response = client.PostAsync(url, requestContent).Result;
                        break;
                    case "PUT":
                        response = client.PutAsync(url, requestContent).Result;
                        break;
                    case "DELETE":
                        response = client.DeleteAsync(url).Result;
                        break;
                }



                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync();
                    responseStatus.JsonString = data.Result;
                    //var data = response.Content.ReadAsStringAsync();
                    //string strmsg = data.Result;
                    //listitems  = JsonConvert.DeserializeObject<List<Item>>(strmsg);
                    //responseStatus = response.Content.ReadAsAsync<ResponseModel>().Result;
                }
                else
                {
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        responseStatus = response.Content.ReadAsAsync<ResponseModel>().Result;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return responseStatus;
        }
    }
    public static class GetApiUrls
    {
        public const string GetOrdersCount = "GetOrdersCount";
        public const string CheckLogin = "CheckLogin";
        public const string GetDealers = "GetDealers";
        public const string InsertDealer = "InsertDealer";
        public const string UpdateDealer = "UpdateDealer";
        public const string DeleteDealer = "DeleteDealer";
        public const string EditDealers = "EditDealers";
        public const string CheckDealerCodeExist = "CheckDealerCodeExist";
        public const string SaveStockcodeDetails = "SaveStockcodeDetails";
        public const string GetPartsMasterDetails = "GetPartsMasterDetails";
        public const string MyRequestorder = "MyRequestorder";
        public const string RequestOrderLines = "RequestOrderLines";
        public const string UpdateRequestOrderStatus = "UpdateRequestOrderStatus";
        public const string GetDealerCodes = "GetDealerCodes";
        public const string GetRecentOrders = "GetRecentOrders";
        public const string GetPartNumbers = "GetPartNumbers";
        public const string GetpartDetails = "GetpartDetails";
        public const string GetDealerStock = "GetDealerStock";
        public const string CreateRequestOrder = "CreateRequestOrder";
        public const string CreateRequestOrderLines = "CreateRequestOrderLines";
        public const string GetSearchHistory = "GetSearchHistory";
        public const string GetRecentSearchParts = "GetRecentSearchParts";
        public const string UserLogin = "UserLogin";
        public const string GetUsers = "GetUsers";
        public const string EditUsers = "EditUsers";
        public const string InsertUser = "InsertUser";
        public const string UpdateUser = "UpdateUser";
        public const string DeleteUser = "DeleteUser";
        public const string CheckUserExists = "CheckUserExists";
        public const string GetDealersCount = "GetDealersCount";        public const string GetUsersCount = "GetUsersCount";

    }
}
