using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using swdAPI.Models.EF;

namespace swdAPI.Controllers
{
    public class PayrollController : ApiController
    {
        GetPayroll payroll = new GetPayroll();

        //GET api/<controller>
        public IEnumerable<Payroll> GetAll()
        {

            return payroll.getPayroll();
        }

        // GET api/<controller>/5
        public IEnumerable<PayrollDTO> Get(int id)
        {
            return payroll.getPayroll(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}