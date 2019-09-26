namespace Garden
{
    public class Plant
    {
        public string Name {get; set;}
        public string Type {get; set;}
        public int Health {get; set;}
        public bool Dead;

        public Plant(string name, string type)
        {
            Name = name;
            Type = type;
            Health = 25;
            Dead = false;
        }   
        public int Water()
        {
            Health = Health + 5;
            return Health;
        }
        public int Feed()
        {
            Health = Health + 5;
            return Health;
        }
        public int Sunshine()
        {
            Health = Health + 1;
            return Health;
        }
        public void CheckDead()
        {
            if(Health <= 0)
            {
                Dead = true;
            }
        }
    }



}
