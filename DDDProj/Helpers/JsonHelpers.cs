using System.Text.Json;
using DDDProj.Users;

namespace DDDProj.Helpers
{
    public static class JsonHelpers
    {
        public static void Serialise(User pUser)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(pUser, options);
            File.WriteAllText($"Users\\{pUser.userType}s\\{pUser.email}.json", jsonString);
        }

        public static User Deserialise(string pUserType, string pEmail)
        {
            var userDeserialised = File.ReadAllText($"Users\\{pUserType}s\\{pEmail}.json");
            Student user = JsonSerializer.Deserialize<Student>(userDeserialised);

            //switch (pUserType) 
            //{
            //    case "Student":
            //        user = JsonSerializer.Deserialize<Student>(userDeserialised);
            //        return user;

            //case "Personal Supervisor":
            //    user = JsonSerializer.Deserialize<PersonalSupervisor>(userDeserialised);
            //    break;

            //case "Senior Supervisor":
            //    user = JsonSerializer.Deserialize<SeniorSupervisor>(userDeserialised);
            //    break;

            //case "Admin":
            //    user = JsonSerializer.Deserialize<Admin>(userDeserialised);
            //    break;

            return user;
        }

    }
}
