using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        }

        public void Post([FromBody]List<Person> value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Person value)
        {
            Person workPers = new Person(value.ID, value.Vorname, value.Nachname, value.Geburtstag);

            bool PersExists = false;
            for (int i = 0; 0 < Global.MCntr.PersList.Count; i++)
            {
                if (Global.MCntr.PersList[i].ID == id)
                {
                    PersExists = true;
                    break;
                }
                else {/*nichts*/}
            }

            if (PersExists)
            {
                Global.MCntr.PersList[id] = workPers;
            }
            else
            {
                Global.MCntr.PersList.Add(workPers);
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}