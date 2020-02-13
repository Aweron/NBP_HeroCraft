using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace NBP_Prototype
{
    public class Profile
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<MongoDBRef> characterRefs;

        public Profile(string user, string pass)
        {
            Username = user;
            Password = pass;

            characterRefs = new List<MongoDBRef>();
        }
    }
}
