using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace GetApiFromPetShop
{
    public class PetStoreClient
    {
        RestClient client = new RestClient("https://petstore.swagger.io/v2");

        public string GetByOrderId(int orderId)
        {
            if (orderId <= 10 && orderId >= 1)
            {
                var request = new RestRequest($"/store/order/{orderId}", Method.GET);
                IRestResponse response = client.Execute(request);

                return response.Content;
            }
            else
            {
                return "Id is invalid.";
            }
        }

        public string PostPet()
        {
            var request = new RestRequest("/pet", Method.POST);
            request.AddHeader("content-type", "application/json");
            string json = @"{
                  ""id"": 13,
                  ""category"": {
                                ""id"": 13,
                    ""name"": ""kotik""
                  },
                  ""name"": ""Kot"",
                  ""photoUrls"": [
                    ""lallaa""
                  ],
                  ""tags"": [
                    {
                      ""id"": 13,
                      ""name"": ""hehehehe""
                    }
                  ],
                  ""status"": ""unavailable""
                }";
            request.AddParameter("text/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
