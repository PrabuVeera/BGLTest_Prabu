using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using BGLTest.Models;
using RestSharp;
using System.IO;
using Newtonsoft.Json;

namespace BGLTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = ""; 
            return View(); 
        }

        public ActionResult SearchUser(UserSearchDetails user)
        {
           
            if (!string.IsNullOrEmpty(user.UserNameToSearch) && !string.IsNullOrEmpty(user.SearchBaseUrl))
            {
                string response = Utils.GetJsonResponse(string.Format("{0}{1}",user.SearchBaseUrl, user.UserNameToSearch));

                if(!string.IsNullOrEmpty(response))
                {
                    User u = Utils.Deserilaize<User>(response);

                    UserRepo[] allUserRepos = GetUserRepo(u);

                    ViewData[Utils.UserSearchResultKey] = u;
                    ViewData[Utils.UserReposResultKey] = allUserRepos.OrderByDescending(x=> x.Stargazers_count)
                        .Take(user.NumberOfReposToGet).ToArray();
                }
                else
                {
                    ModelState.AddModelError("", "No user found.");
                }

            }
            return View("User");
        }


        #region GetUserRepo(User _user)
        /// <summary> 
        /// Gets the user repos for a user
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public UserRepo[] GetUserRepo(User _user)
        {
            UserRepo[] retVal = new UserRepo[] { };

            if (!string.IsNullOrEmpty(_user.Repos_url))
            {
                string userReposJson = Utils.GetJsonResponse(_user.Repos_url);
                retVal = Utils.Deserilaize<UserRepo[]>(userReposJson);
            }

            return retVal;
        }


        #endregion GetUserRepo(User _user)

        
    }
}
