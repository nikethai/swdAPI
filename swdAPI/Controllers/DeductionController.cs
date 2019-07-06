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
    public class DeductionController : ApiController
    {
        GetDeduction gc = new GetDeduction();
        List<Deduction> listDeduct;

        public IEnumerable<Deduction> GetAllDeduction()
        {
            listDeduct = gc.getDeduction();

            return listDeduct;
        }
        public IEnumerable<DeductionDTO> GetDeduction(int id)
        {
            var getDeduct = gc.getDeduction(id);
            return getDeduct;
        }

    }
}