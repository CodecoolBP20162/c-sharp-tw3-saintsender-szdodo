using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    [Serializable]
    class User : ISerializable, IDeserializationCallback
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        [NonSerialized] public string UserName;

        public User(string EmailAddress, string Password)
        {
            this.EmailAddress = EmailAddress;
            this.Password = Password;
            UserName = EmailAddress.Substring(0, EmailAddress.Length - 10);
        }

        public User() { }

        public User(SerializationInfo info, StreamingContext context)
        {
            EmailAddress = (string)info.GetValue("EmailAddress", typeof(string));
            Password = (string)info.GetValue("Password", typeof(string));
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            UserName = EmailAddress.Substring(0, EmailAddress.Length - 10);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EmailAddress", EmailAddress, typeof(string));
            info.AddValue("Password", Password, typeof(string));
            
        }

        public void Serialize()
        {

            string fileName = "userconfig.dat";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                Console.Read();
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static User Deserialize()
        {
            User user = new User();

            try
            {
                FileStream fs = new FileStream("userconfig.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();
                user = (User)formatter.Deserialize(fs);
                fs.Close();
            }
            catch (FileNotFoundException) { }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                Console.Read();
                throw;
            }

            return user;
        }

    }
}
