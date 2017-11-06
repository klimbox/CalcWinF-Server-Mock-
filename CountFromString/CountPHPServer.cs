using System;
using System.IO;
using System.Net;

namespace CountFromString
{
    public class CountPHPServer
    {
        private static string url = "http://localhost/ForSelenium/count.php";

        public static int CalculationRequest(int num1, int num2, string op)
        {
            int res = 0;

            if (op == "+")
                op = "%2b";

            string req = "?num1=" + num1 + "&num2=" + num2 + "&opr=" + op;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+req);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader input = new StreamReader(response.GetResponseStream());

            string reqRes = input.ReadToEnd();
            
            try
            {
                res = Convert.ToInt32(reqRes);
            }
            catch (Exception)
            {  }

            return res;
        }
    }
}
