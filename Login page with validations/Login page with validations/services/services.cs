using Login_page_with_validations.Models;
namespace Login_page_with_validations.services
{
    public class services
    {
        private static List<LoginModel> data = new List<LoginModel>();

        public static List<LoginModel> getall
        {
            get { return data; }
        }

        public static void search(LoginModel user)
        {
            int i = 0;
            if (i == 0)
            {
                data.Add(user);
                i++;
            }
            else
            {
                foreach (LoginModel item in data)
                {
                    if (user.Email == item.Email)
                    {
                        Console.WriteLine("Email already found");
                    }
                    else
                    {
                        data.Add(user);
                    }
                }
            }
        }
    }
}
