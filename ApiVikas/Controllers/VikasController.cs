using ApiVikas.DB_Entity;
using ApiVikas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiVikas.Controllers
{
    public class VikasController : ApiController
    {
        
        [HttpGet]
        [Route("Stu/Vikas")]
        public List<string> Stu()
        {

            List<string> ob = new List<string>()
            {
                "Vikas",
                "Ram",
                "Shiv"
            };

            return ob;

        }


        [HttpGet]
       // [Route("Stu/Ram")]
        public List<DataModel> Stu1()
        {
            TemplateEntities te = new TemplateEntities();

            var re = te.Logiuses.ToList();



            List<DataModel> ob = new List<DataModel>();

            foreach( var item in re)
            {
                ob.Add(new DataModel{

                    id=item.id,
                    name=item.name,
                    password=item.password,
                    email=item.email
                });
            }

            return ob;
         

        }


    }
}