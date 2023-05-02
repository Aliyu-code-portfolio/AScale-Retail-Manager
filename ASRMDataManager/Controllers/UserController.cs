using ASRMDataManager.Library.DataAccess;
using ASRMDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace ASRMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        // GET: User
        public UserModel GetById()
        {
            string id = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserById(id).First();
        }
    }
}