using MKVmergeBatcher.src.obj;
using Newtonsoft.Json;
using System.IO;

namespace MKVmergeBatcher.src
{

    class UserDataJsonManagement
    {
        UserData ud = new UserData();

        public UserData ReadUserData()
        {
            if (File.Exists(@"userdata.json"))
            {
                string json = File.ReadAllText(@"userdata.json");
                ud = JsonConvert.DeserializeObject<UserData>(json);
            }
            else
            {
                ud = WriteUserData(ud);
            }
            return ud;
        }
        public UserData WriteUserData(UserData userData)
        {
            userData = userData.SetDefaultData(userData);
            string json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(@"userdata.json", json);
            return userData;
        }
    }
}
