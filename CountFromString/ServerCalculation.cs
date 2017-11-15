using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CountFromString
{
    public class ServerCalculation : ICalculation
    {
        private HttpClient _client;
        private string _deffaultUrl = "http://localhost:8080";

        public ServerCalculation()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_deffaultUrl);
        }

        public ServerCalculation(string url)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(url);
        }

        public int Calculate(string num1, string num2, string op)
        {
            int res = 0;

            if (op == "+")
                op = "%2b";

            var content = new StringContent("num1=" + num1 + "&num2=" + num2 + "&opr=" + op);

            var result = _client.PostAsync("/api/Membership/exists", content).Result;

            if (result.IsSuccessStatusCode)
            {
                var responseContent = result.Content;

                // by calling .Result you are synchronously reading the result
                string responseString = responseContent.ReadAsStringAsync().Result;
                try
                {
                    res = Convert.ToInt32(responseString);
                }
                catch (Exception)
                { }

            }            

            return res;
        }
    }
}
