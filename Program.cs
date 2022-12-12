using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace _12._10._22.Fil
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region tekraryazi
           
            #region Tasktekrar
            //Task task = new Task();
            //task.Id = 69;
            //task.Surname = "ibrahimov";
            //task.Name = "cebrayil";
            //task.Age = 65;
            #endregion
            #region xml
            //SerializeXml(task);
            //Console.WriteLine(GetXml());
            #endregion
            #region Dat
            //ShowBinary(task);


            //Console.WriteLine(GetBinary());
            #endregion
            #endregion

            User user = new User();
            user.Id = 66;
            user.Name = "Eli";
            user.Surname = "Eliyev";
            user.UserName ="f15";

            #region XmlEvtTapsirigi
            //ShowXml(user);
            //var Data = GetXml();
            //Console.WriteLine(Data);
            #endregion
            

            //JsonShow(user);

        }
        #region tekraryazi
        #region Dat
        //public static void ShowBinary(Task task)
        //{
        //    string pat = "C:\\Users\\User\\Desktop\\Task.dat";
        //    Stream stream = new FileStream(pat, FileMode.Create);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    binaryFormatter.Serialize(stream, task);

        //}

        //public static Task GetBinary()
        //{
        //    string caps = "C:\\Users\\User\\Desktop\\Task.dat";
        //    Stream stream1 = new FileStream(caps, FileMode.Open);
        //    BinaryFormatter binFormatter = new BinaryFormatter();
        //    var taske = (Task)binFormatter.Deserialize(stream1);
        //    return taske;
        //}
        #endregion
        #region Xml
        //public static void SerializeXml(Task taskxml)
        //{
        //    string xml = "C:\\Users\\User\\Desktop\\Xml.xml";
        //    Stream stream = new FileStream(xml, FileMode.Create);

        //    XmlSerializer serializer = new XmlSerializer(typeof(Task));
        //    serializer.Serialize(stream, taskxml);

        //}
        //public static Task GetXml()
        //{
        //    string xml1 = "C:\\Users\\User\\Desktop\\Xml.xml";
        //    Stream streamxml = new FileStream(xml1, FileMode.Open);    

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Task));
        //    var tasking = (Task)xmlSerializer.Deserialize(streamxml);
        //    return tasking;
        //}
        #endregion
        #endregion


        #region XmlEvTapsirigi
        //public static void ShowXml(User user)
        //{
        //    string patch = "C:\\Users\\User\\Desktop\\TapsiriqEve.xml";
        //    Stream stream = new FileStream(patch, FileMode.Create);

        //    XmlSerializer serializer = new XmlSerializer(typeof(User));
        //    serializer.Serialize(stream, user);
        //}
        //public static User GetXml()
        //{
        //    string getxml = "C:\\Users\\User\\Desktop\\TapsiriqEve.xml";
        //    Stream stream = new FileStream(getxml, FileMode.Open);
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
        //    var ComingXml  = (User)xmlSerializer.Deserialize(stream);
        //    return ComingXml;
        //}
        #endregion

        #region BinaryEvTapsirigi
        //public static void ShowBinary(User user)
        //{
        //    string showbinary = "C:\\Users\\User\\Desktop\\TapsiriqEveBinary.dat";
        //    Stream stream = new FileStream(showbinary, FileMode.Create);

        //    BinaryFormatter binaryformatter = new BinaryFormatter();
        //    binaryformatter.Serialize(stream, user);
        //}

        //public static User GetBinary()
        //{
        //    string showbinary = "C:\\Users\\User\\Desktop\\TapsiriqEveBinary.dat";
        //    Stream stream1 = new FileStream(showbinary, FileMode.Open);

        //    BinaryFormatter binaryformatter = new BinaryFormatter();
        //    var cominginary = (User)binaryformatter.Deserialize(stream1);
        //    return cominginary;
        //}

        #endregion

        #region JsonEvTapsirigiSehv
        //public static void JsonShow(User user)
        //{
        //    string place = "C:\\Users\\User\\Desktop\\TapsiriqEve.json";
        //    Stream stream = new FileStream(place, FileMode.Create);
        //    //JsonSerializerOptions jsonSerializer = new JsonSerializerOptions();
        //    //JsonSerializer.Serialize(stream, jsonSerializer);
        //    JsonSerializer serializer = new JsonSerializer();


        }


    #endregion





}
}

