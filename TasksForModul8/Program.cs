using System;
using System.IO;
using System.Xml.Linq;

namespace TasksForModul8
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        
        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(PhoneNumber);
            writer.Write(Email);
        }

       
        public static Contact Deserialize(BinaryReader reader)
        {
            string name = reader.ReadString();
            long phoneNumber = reader.ReadInt64();
            string email = reader.ReadString();

            return new Contact(name, phoneNumber, email);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("Egor Egorik", 2281141251, "egorikkkkkk@noname.ru");

            using (FileStream fs = new FileStream(@"C:\\Users\1\Desktop\contact.bin", FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                contact.Serialize(writer);
            }

            
            Contact deserializedContact;
            using (FileStream fs = new FileStream(@"C:\\Users\1\Desktop\contact.bin", FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                deserializedContact = Contact.Deserialize(reader);
            }

           
            Console.WriteLine($"Name: {deserializedContact.Name}, Phone: {deserializedContact.PhoneNumber}, Email: {deserializedContact.Email}");
        }
    }
}



