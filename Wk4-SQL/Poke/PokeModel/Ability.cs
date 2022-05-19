namespace PokeModel
{
    public class Ability
    {
        public string Name { get; set; }

        //PowerPoint cannot be negative
        private int _PP;
        public int PP
        {
            get { return _PP; }
            set 
            {
                if (value > 0)
                {
                    _PP = value;
                }
                else
                {
                    Console.WriteLine("PowerPoint cannot be negative");
                }
            }
        }
        
        public int Power { get; set; }

        public override string ToString()
        {
            return $"=======\nName: {Name}\nPP: {PP}\nPower: {Power}\n=======";
        }
    }
}