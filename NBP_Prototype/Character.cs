using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using MongoDB.Bson;
using MongoDB.Driver;

namespace NBP_Prototype
{
    public class Character
    {
        public MongoDBRef ProfileRef { get; set; }
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public Bitmap Picture { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public int[] stats;

        public string Title { get { return Name + ", the " + Race + " " + Class; } }

        public Character()
        {
            Name = "";
            Race = "";
            Class = "";
            Points = 27;
            Description = "";

            stats = new int[6];
        }

        public Character(Character character)
        {
            ProfileRef = character.ProfileRef;
            Id = character.Id;

            Name = character.Name;
            Race = character.Race;
            Class = character.Class;
            Picture = character.Picture;
            Points = character.Points;
            Description = character.Description;

            stats = new int[6];
            Array.Copy(character.stats, stats, 6);
        }
    }
}
