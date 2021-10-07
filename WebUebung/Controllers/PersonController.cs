using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebUebung.Controllers
{
    public class PersonController : ApiController
    {
        private Maincontroller _mCntr;

        public Maincontroller mCntr { get => _mCntr; set => _mCntr = value; }

        public PersonController()
        {
            mCntr = Global.MCntr;
        }

        public PersonController(Maincontroller MCntr)
        {
            mCntr = MCntr;
        }

        // GET api/<controller>
        public List<Person> Get()
        {
            return Global.MCntr.PersList;
        }

        public List<Person> Get(List<int> IDList)
        {
            List<Person> Perslist = new List<Person>();
            for (int i = 0; i < IDList.Count; i++)
            {
                Perslist.Add(Global.MCntr.PersList[IDList[i]]);
            }
            return Perslist;
        }

        // GET api/<controller>/5
        public Person Get(int id)
        {
            try
            {
                return Global.MCntr.PersList[id];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]Person value)
        {
            Person workPers = new Person(value.ID, value.Vorname, value.Nachname, value.Geburtstag);
            Global.MCntr.PersList.Add(workPers);
        }

        public void Post([FromBody]List<Person> value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Person value)
        {
            Person workPers = new Person(value.ID, value.Vorname, value.Nachname, value.Geburtstag);
            Global.MCntr.PersList[Global.MCntr.GetListID(value.ID)] = workPers;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Person delPers = Global.MCntr.PersList[id];
            Global.MCntr.PersList.Remove(delPers);
        }
    }
}