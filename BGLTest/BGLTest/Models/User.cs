using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BGLTest.Models
{
    public class User
    {

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("avatar_url")]
        public string Avatar_url { get; set; }

        [JsonProperty("gravatar_id")]
        public string Gravatar_id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string Html_url { get; set; }

        [JsonProperty("followers_url")]
        public string Followers_url { get; set; }

        [JsonProperty("following_url")]
        public string Following_url { get; set; }

        [JsonProperty("gists_url")]
        public string Gists_url { get; set; }

        [JsonProperty("starred_url")]
        public string Starred_url { get; set; }

        [JsonProperty("subscriptions_url")]
        public string Subscriptions_url { get; set; }

        [JsonProperty("organizations_url")]
        public string Organizations_url { get; set; }

        [JsonProperty("repos_url")]
        public string Repos_url { get; set; }

        [JsonProperty("events_url")]
        public string Events_url { get; set; }

        [JsonProperty("received_events_url")]
        public string Received_events_url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool Site_admin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public object Hireable { get; set; }

        [JsonProperty("bio")]
        public object Bio { get; set; }

        [JsonProperty("public_repos")]
        public int Public_repos { get; set; }

        [JsonProperty("public_gists")]
        public int Public_gists { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("created_at")]
        public DateTime Created_at { get; set; }

        [JsonProperty("updated_at")]
        public DateTime Updated_at { get; set; }
    }
}