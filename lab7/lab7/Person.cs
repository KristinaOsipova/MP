using System.Dynamic;

namespace lab7
{
    public class Person
    {
        private string fam
        {
            set
            {
                if (fam == "") fam = value;
            }
            get { return fam; }
        }

        private readonly string status;

        private int salary { set { salary = value; } }
        public int age;
        private string health;

        public string getHealth()
        {
            return health;
        }

        public void setHealth(string newHealth)
        {
            health = newHealth;
        }
    }
}