using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Main
{
    class Programm
    {


        public static void Main(string[] args)
        {
            Console.Out.WriteLine(VKAPI.VKAPI.VkAsk("https://api.vk.com/method/users.get?user_id=210700286&v=5.52"));
            Console.ReadKey();
        }
    }
}
