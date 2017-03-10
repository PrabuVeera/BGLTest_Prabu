using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BGLTest.Models
{
    /// <summary>
    /// Class that represents the search parameters
    /// </summary>
    public class UserSearchDetails
    {
        [Required(ErrorMessage = "Serach Url is required.")]
        public string SearchBaseUrl { get; set; }


        [Required(ErrorMessage = "User name is required.")]
        public string UserNameToSearch { get; set; }

        public int NumberOfReposToGet { get; set; }


        public UserSearchDetails()
        {
        }


        /// <summary>
        /// Gets the list of items to be displayed to give the option to user
        /// </summary>
        /// <returns></returns>
        public static SelectListItem[] GetListItems()
        {
            int[] retVal = new int[] {1, 2, 3,4 ,5,6 ,7, 8, 9, 10};

            return retVal.Select(x => new SelectListItem() { Selected = x == 5, Text = x + "", Value = x+ "" }).ToArray();
        }
    }
}