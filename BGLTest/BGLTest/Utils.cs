using System.Web.Mvc;
using System.Reflection;
using BGLTest.Models;
using RestSharp;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace BGLTest
{
    /// <summary>
    /// Utils class
    /// </summary>
    public static class Utils
    {
        public static string UserSearchResultKey = "User";
        public static string UserReposResultKey = "UserRepos";

        #region  Deserilaize<T>(string json)
        /// <summary>
        /// Deserializes Json string to pthe object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserilaize<T>(string json)
        {
            T retVal = default(T);
            using (var sr = new StringReader(json))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    var js = new Newtonsoft.Json.JsonSerializer();
                    retVal = js.Deserialize<T>(jr);
                }
            }
            return retVal;
        }

        #endregion Deserilaize<T>(string json)

        #region GetJsonResponse(string _url)
        /// <summary>
        /// Calls the url using the REST api and returns the json reponse content
        /// </summary>
        /// <param name="_url"></param>
        /// <returns></returns>
        public static string GetJsonResponse(string _url)
        {
            string retVal = "";

            try
            {
                var client = new RestClient(_url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    retVal = response.Content;
                }
            }
            catch (System.Exception)
            {
                retVal = null;
            }

            return retVal;
        }

        #endregion GetJsonResponse(string _url)

    }    
}