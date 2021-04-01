using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    class Player
    {
        protected string name;
        protected string surname;
        protected int age;
        protected string nationality;
        protected string nickname;
        protected string team;
        protected string role;
        protected string condition;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {

            get { return age; }
            set
            { age = value; }

        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public static string LineCheck()
        {
            string data;
            do
            {
                int correctness = 0;
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                for (int i = 0; i < data.Length; i++)
                {
                    if (!char.IsLetter(data[i]))
                    {
                        Console.Write("Use only characters \n");
                        correctness = 1;
                        break;
                    }
                }
                if (correctness != 0) continue;
                else break;
            } while (true);
            return data;

        }
        public static string TeamNicknameLineCheck()
        {
            string data;
            do
            {
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);

            return data;
        }
        public static int Agecheck()
        {
            string age;
            int ageint;
            while (true)
            {
                age = Console.ReadLine();
                if (!int.TryParse(age, out ageint))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            return ageint;
        }

        public static string RoleChoosing()
        {
            string plrole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = "awper";
                        choice = true;
                        break;
                        
                    case '2':
                        plrole = "rifler";
                        choice = true;
                        break;
                    case '3':
                        plrole = "captain";
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return plrole;
        }
        public void TeamChanger()
        {
            string teamnew = "";
            Console.WriteLine("enter new team name");
            do
            {
                teamnew = Console.ReadLine();
                if (teamnew.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);
            team = teamnew;
        }
        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality+
                "\nHis team is: " + team+"\nNickname is: " + nickname + "\nPlayer role is: " + role);
        }
        public void NewAge()
        {
            int age_new;
            Console.WriteLine("Enter new player's age:");
            string age_new2;
            while (true)
            {
                age_new2 = Console.ReadLine();
                if (!int.TryParse(age_new2, out age_new))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            age = age_new;
        }
        public Player()
        {
            //amountOfObjects++;
            Console.WriteLine("Name of the player");
            Name = Player.LineCheck();
            Console.WriteLine("Surname of the player:");
            Surname = Player.LineCheck();

            Console.WriteLine("Age is");
            Age = Player.Agecheck();
            Console.WriteLine("Nationality is");
            Nationality = LineCheck();
            Console.WriteLine("His team is");
            Team = TeamNicknameLineCheck();
            Console.WriteLine("Player's nickname is");
            Nickname = TeamNicknameLineCheck();
            Console.WriteLine("Choose Player's role\n1 - awper \n2 - rifler\n3 - captain");
            Role = RoleChoosing();
        }
        public void NameChanger()
        {
            Console.WriteLine("Enter new nickname");
            string data;
            do
            {
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);

            nickname = data;
            }
        public void Kill()
        {
            condition = " (dead)";
        }
        public void RoleChanger()
        {
            Console.WriteLine("Choose new role: \n 1 - awper \n2 - rifler\n3 - captain");
            string plrole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = "awper";
                        choice = true;
                        break;

                    case '2':
                        plrole = "rifler";
                        choice = true;
                        break;
                    case '3':
                        plrole = "captain";
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = plrole;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Player first = new Player();
                bool close = false;
                char task;
                Console.Clear();
                while (close == false)
                {

                    Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change team \n 3 - change age\n 4 - change nickname \n 5 - change role\n 6 - kill \n 7 - close");
                    task = Console.ReadKey().KeyChar;
                    switch (task)
                    {
                        case '1':
                            first.ShowInfo();
                            break;
                        case '2':
                            Console.Clear();
                            first.TeamChanger();
                            break;
                        case '3':
                            Console.Clear();
                            first.NewAge();
                            break;
                        case '4':
                            Console.Clear();
                            first.NameChanger();
                            break;
                        case '5':
                            Console.Clear();
                            first.RoleChanger();
                            break;
                        case '6':
                            Console.Clear();
                            first.Kill();
                            Console.WriteLine("Now you are a killer");
                            break;
                        case '7':
                            close = true;
                            break;
                        default:
                            Console.WriteLine("Excellent choice");
                            break;
                    }
                }
            }
        }
    }
}
