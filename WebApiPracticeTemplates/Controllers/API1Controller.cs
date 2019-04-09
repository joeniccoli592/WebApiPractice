using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPracticeTemplates.Models.AnimalModels;


namespace WebApiPracticeTemplates.Controllers
{
	[RoutePrefix("api/animals")]
    public class Api1Controller : ApiController
    {
	    [Route, HttpGet]

	    public HttpResponseMessage Animal1()
	    {
		    if (!ModelState.IsValid)
		    {
			    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
		    }
		    return Request.CreateResponse(HttpStatusCode.OK, true);
	    }


	    [Route ("{id}:int"), HttpGet]

		public HttpResponseMessage GetById(int id)
		{
			if (!ModelState.IsValid)
			{
				return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
			}
			return Request.CreateResponse(HttpStatusCode.OK, true);
		}

		[Route(), HttpPost]
	    public HttpResponseMessage Add(AnimalModel model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
		    }
		    return Request.CreateResponse(HttpStatusCode.OK, model);
	    }


	    [Route("{id}:int"), HttpPut]
	    public HttpResponseMessage Update(UpdateAnimalsModels model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
		    }
		    return Request.CreateResponse(HttpStatusCode.OK, model);
	    }


	    [Route("{id}:int"), HttpDelete]
	    public HttpResponseMessage Delete(UpdateAnimalsModels model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
		    }
		    return Request.CreateResponse(HttpStatusCode.OK, model);
	    }
	}

}
