using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebUebung.Controllers
{
    public class Maincontroller
    {
        private List<Person> _persList;

        public List<Person> PersList { get => _persList; set => _persList = value; }

        public Maincontroller()
        {
            PersList = new List<Person>();
        }

        public Maincontroller(List<Person> persList)
        {
            PersList = persList;
        }

        public void AddPers()
        {
            PersList.Add(new Person(1, "Sebastian", "Schmitz", "20.02.1990"));
            PersList.Add(new Person(2, "Daniel", "Schüttke", "13.05.1991"));
            PersList.Add(new Person(3, "Dieter", "Vogel", "15.08.1984"));
        }

        public void ReadApi()
        {
            string url = "http://localhost:62197/api/person";
            string json = JsonConvert.SerializeObject(PersList);
            cReadApi(url, json);
        }

        public void ReadApi(int ID)
        {
            string url = "http://localhost:62197/api/person/"+ID.ToString();
            string json = JsonConvert.SerializeObject(PersList[ID]);
            cReadApi(url, json);
        }

        private void cReadApi(string URL, string Json)
        {
            HttpClient hClient = new HttpClient();
            Task<HttpResponseMessage> response = hClient.GetAsync(URL);

            try
            {
                response.Wait();
            }
            catch(Exception e)
            {
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        public void WriteApi()
        {

        }
    }
}