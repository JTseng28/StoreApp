using System.Text.Json;
using DAL;
using Model;

namespace DAL
{
    public class Repository : IRespository
    {
        private string _filepath = "../DAL/Database/";
        private string _jsonStringObj;

        public User AddUser(User p_user)
        {
            string path = _filepath + "Users.json";

            _jsonStringObj = JsonSerializer.Serialize(p_user, new JsonSerializerOptions { WriteIndented = true});

            File.WriteAllText(path, _jsonStringObj);
            
            return p_user;
        }
    }

} 