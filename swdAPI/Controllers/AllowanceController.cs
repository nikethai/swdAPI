using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using swdAPI.Models.EF;
using System.Web.Http;
using System.Collections;

namespace swdAPI.Controllers
{
    public class AllowanceController : ApiController
    {
        GetAllowance gc = new GetAllowance();
        List<Allowance> listAllow;

        public IEnumerable<Allowance> GetAllAllowance()
        {
            listAllow = gc.getAllowance();

            return listAllow;
        }
        public IEnumerable<AllowanceDTO> GetAllowance(int id)
        {
            var getAllow = gc.getAllowance(id);
            return getAllow;
        }

    }
}