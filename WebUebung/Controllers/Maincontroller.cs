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

        public string ReadApi()
        {
            string url = "http://localhost:62197/api/person";
            string json = JsonConvert.SerializeObject(PersList);
            string empfang = cReadApi(url, json);
            return empfang;
        }

        public string ReadApi(int ID)
        {
            string url = "http://localhost:62197/api/person/"+ID.ToString();
            string json = JsonConvert.SerializeObject(PersList[ID]);
            string empfang = cReadApi(url, json);

            return empfang;
        }

        private string cReadApi(string URL, string Json)
        {
            string empfang = "fehlgeschlagen";
            HttpClient hClient = new HttpClient();
            Task<HttpResponseMessage> response = hClient.GetAsync(URL);

            try
            {
                response.Wait();
            }
            catch(Exception e)
            {

            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
                empfang = content.Result;
            }
            catch (Exception e)
            {

            }
            return empfang;
        }

        public void PostApi(Person PostPerson)
        {
            string url = "http://localhost:62197/api/person/" + Global.MCntr.GetListID(PostPerson.ID);
            string json = JsonConvert.SerializeObject(PostPerson);

            HttpClient hClient = new HttpClient();
            Task<HttpResponseMessage> response = hClient.PostAsJsonAsync<Person>(url, PostPerson);

            try
            {
                response.Wait();
            }
            catch (Exception e)
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

        public void PutApi(Person PutPerson)
        {
            string url = "http://localhost:62197/api/person/" + Global.MCntr.GetListID(PutPerson.ID);
            string json = JsonConvert.SerializeObject(PutPerson);

            HttpClient hClient = new HttpClient();
            Task<HttpResponseMessage> response = hClient.PostAsJsonAsync<Person>(url, PutPerson);

            try
            {
                response.Wait();
            }
            catch (Exception e)
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

        public void DeleteApi(int ID)
        {
            int ListID = -1;
            for (int I=0; I < Global.MCntr.PersList.Count; I++)
            {
                if (Global.MCntr.PersList[I].ID == ID)
                {
                    ListID = I;
                    break;
                }
            }
            if (ListID != -1)
            {
                /*
                string url = "http://localhost:62197/api/person/" + ListID;
                string json = JsonConvert.SerializeObject(null);

                HttpClient hClient = new HttpClient();
                Task<HttpResponseMessage> response = hClient.PutAsJsonAsync<Person>(url, PutPerson);

                try
                {
                    response.Wait();
                }
                catch (Exception e)
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
                */
            }
        }

        public int GetListID(int PersID)
        {
            int ListID = -1;
            for (int I=0; I < PersList.Count; I++)
            {
                if (PersList[I].ID == PersID)
                {
                    ListID = I;
                    break;
                }
            }
            return ListID;
        }

        public int IncListID()
        {
            int newListID = -1;
            for (int I = 0; I < PersList.Count; I++)
            {
                if (PersList[I].ID > newListID)
                {
                    newListID = PersList[I].ID + 1;
                }
            }
            return newListID;
        }
    }
}