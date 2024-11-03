using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taskProject
{
     class user
    {

         public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber  { get; set; }

        public void AddUser (List <user> users  )
        {
            Console.WriteLine(" ***************************************");
            Console.WriteLine(" Enter your Name ");
            string name =Console.ReadLine ();
            Console.WriteLine(" Enter your Email ");
            string email = Console.ReadLine ();
            Console.WriteLine(" Enter your PohneNumber ");
            string phoneNumber = Console.ReadLine ();
             user newUser = new user {
             
             Name = name,Email = email, PhoneNumber = phoneNumber
             
             };
        
        users.Add (newUser);
            Console.WriteLine("*************************");
            Console.WriteLine($"the name is {newUser.Name} ");
            Console.WriteLine($"the Email is {newUser.Email} ");
            Console.WriteLine($"the PhoneNumber is {newUser.PhoneNumber} ");
        }
        public void UpdateUser(List<user> users) 
        { 
        string Pohnum =Console.ReadLine ();
            user found = users.FirstOrDefault(newu => newu.PhoneNumber == Pohnum);

            if (found != null)
            {
                Console.WriteLine(" choose number for update\n 1-name \n 2-Email \n 3-phone number  ");
            
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1) {
                    Console.WriteLine(" Enter New Name ");
                string name =Console.ReadLine ();
                    found.Name = name;  
                
                }
                else if (choose == 2) {
                    Console.WriteLine(" Enter New email ");
                    string email = Console.ReadLine();
                    found.Email = email;
                }
                else if (choose == 3) {
                    Console.WriteLine(" Enter New phone number ");
                    string phone = Console.ReadLine();
                    found.PhoneNumber = phone;
                }
                else { Console.WriteLine("nothing "); }
                Console.WriteLine($"new name {found.Name } ");
                Console.WriteLine($"new name {found.Email} ");
                Console.WriteLine($"new name {found.PhoneNumber} ");

            }




        }

public void DeletUser ( List<user> users)
        {
            string Pohnum =Console.ReadLine ();
            user found = users.FirstOrDefault(newu => newu.PhoneNumber == Pohnum);
            if (found != null) {
                users.Remove(found);

                Console.WriteLine(found.Name );
            }
            else { Console.WriteLine(" nothing "); }
        }
        public void PrintAllUsers(List<user>users)
        {
        int count = 1;

            if (users == null || count <=0 ) { Console.WriteLine(" nothing "); }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"cont is : {count}");
                    Console.WriteLine($"cont is : {user.Name}");
                    Console.WriteLine($"cont is : {user.Email}");
                    Console.WriteLine($"cont is : {user.PhoneNumber}");
                    count++;

                }
            }


        }
    }
}
