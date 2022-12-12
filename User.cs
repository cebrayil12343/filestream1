using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._22.Fil
{
    [Serializable]
    public class User:ISerializable
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           info.AddValue("id", Id , typeof(int));
           info.AddValue("name", Name , typeof(string));
           info.AddValue("Surname" , Surname , typeof(string));
           info.AddValue("UserName" , UserName , typeof(string));
        }

        public User()
        {

        }
        public User(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("id", typeof(int));
            Name = (string)info.GetValue("name", typeof(string));
            Surname = (string)info.GetValue("surname", typeof(string));
            UserName = (string)info.GetValue("Usernam", typeof(string));
        }

        public override string ToString()
        {
            return $"Id: {Id} \nNmame: {Name}\nSurname: {Surname}\nUserName: {UserName}";
        }

    }
}
