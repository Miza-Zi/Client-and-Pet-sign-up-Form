using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_1_Code.Classes
{

    [Serializable]
    public class PetClass

    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public string OwnerID { get; set; }

        public PetClass()
        {
            Name = "";
            Type = "";
            Age = 0;
            OwnerID = "";
        }

        public PetClass(string name, string type, int age, string ownerID)
        {
            Name = name;
            Type = type;
            Age = age;
            OwnerID = ownerID;
        }
    }
}
