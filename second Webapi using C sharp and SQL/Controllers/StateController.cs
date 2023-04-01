using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using second_Webapi_using_C_sharp_and_SQL.Models;
using System.Data;

namespace second_Webapi_using_C_sharp_and_SQL.Controllers
{
    public class StateController : ApiController
    {
        public HttpRequestMessage get()
        {
            DataTable table = new DataTable();
            string query = @"select State_Name,State_ID from dbo.State";
        }
    }
}
