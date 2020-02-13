using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace NBP_Prototype
{
    class MongoManager
    {
        public MongoDatabase MongoConnection()
        {
            return MongoServer.Create("mongodb://localhost/?safe=true").GetDatabase("HeroCraft");
        }

        #region Profiles

        // Checks if username exists in Mongo
        public bool ProfileExistsInDB(string username)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Profile>("profiles");

            int count = collection.Find(Query.EQ("Username", username)).Count<Profile>();

            if (count == 0)
                return false;
            else
                return true;
        }

        // Checks if username and password exist in Mongo
        public bool ProfileAuthentication(string username, string password)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Profile>("profiles");

            int count = collection.Find(Query.And(Query.EQ("Username", username), Query.EQ("Password", password))).Count<Profile>();

            if (count == 0)
                return false;
            else
                return true;
        }

        // Returns Profile of given username
        public Profile GetProfileData(string user)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Profile>("profiles");

            return collection.Find(Query.EQ("Username", user)).First();
        }

        // Saves new profile to Mongo
        public void SaveProfile(Profile profile)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Profile>("profiles");

            collection.Insert(profile);
        }

        #endregion

        #region Characters

        // Updates Character references of given Profile
        public void UpdateProfileRefs(Profile profile)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Profile>("profiles");

            var query = Query.EQ("_id", profile.Id);
            var update = Update.SetWrapped("characterRefs", profile.characterRefs);
            collection.Update(query, update);
        }

        // Returns a list of Characters of given Profile
        public List<Character> GetCharacters(Profile profile)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Character>("characters");

            List<Character> characters = new List<Character>();

            foreach (MongoDBRef characterRef in profile.characterRefs)
            {
                Character character = db.FetchDBRefAs<Character>(characterRef);
                characters.Add(character);
            }
            return characters;
        }

        // Inserts a new Character
        public void SaveCharacter(Profile profile, Character character)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Character>("characters");

            character.ProfileRef = new MongoDBRef("profile", profile.Id);

            collection.Insert(character);

            profile.characterRefs.Add(new MongoDBRef("characters", character.Id));
        }

        //
        public void UpdateCharacter(Character character)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Character>("characters");

            var query = Query.EQ("_id", character.Id);
            var update = Update.Replace(character);
            collection.Update(query, update);
        }

        // Deletes a Character
        public void DeleteCharacter(Character character)
        {
            MongoDatabase db = MongoConnection();
            var CharacterCollection = db.GetCollection<Character>("characters");
            var ProfileCollection = db.GetCollection<Profile>("profiles");

            var query = Query.EQ("_id", character.ProfileRef.Id);
            var update = Update.Pull("characterRefs", Query.EQ("$id", character.Id));
            ProfileCollection.Update(query, update);

            CharacterCollection.Remove(Query.EQ("_id", character.Id));
        }

        public List<Character> SearchCharacters(string name, string race, string _class)
        {
            MongoDatabase db = MongoConnection();
            var collection = db.GetCollection<Character>("characters");

            // Return all characters
            if (name == "" && race == "<Empty>" && _class == "<Empty>")  
                return collection.FindAll().ToList();
            // No name given
            else if (name == "")
            {
                // Return characters with given class
                if (race == "<Empty>") 
                    return collection.Find(Query.EQ("Class", _class)).ToList();

                // Return character with given race
                else if (_class == "<Empty>") 
                    return collection.Find(Query.EQ("Race", race)).ToList();

                // Return character with given race and class
                else return collection.Find(Query.And(Query.EQ("Race", race), Query.EQ("Class", _class))).ToList(); 
            }
            // Return Character by name
            else
            {
                // Return characters with given name and class
                if (race == "<Empty>" && _class != "<Empty>")
                    return collection.Find(Query.And(Query.EQ("Name", name), Query.EQ("Class", _class))).ToList();

                // Return character with given name and race
                else if (_class == "<Empty>" && race != "<Empty>")
                    return collection.Find(Query.And(Query.EQ("Name", name), Query.EQ("Race", race))).ToList();

                // Return character with given name
                else if (_class == "<Empty>" && race == "<Empty>")
                    return collection.Find(Query.EQ("Name", name)).ToList();

                // Return character with given name, race and class
                else return collection.Find(Query.And(Query.EQ("Name", name), Query.EQ("Race", race), Query.EQ("Class", _class))).ToList();
            }
        }

        #endregion

    }
}
