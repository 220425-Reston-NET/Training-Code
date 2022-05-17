using System.ComponentModel.DataAnnotations;

namespace PokeModel
{
    public class Pokemon
    {
        //This is a field
        private int _pokeId;
        //This is a property
        //I want pokeID to only hold positive numbers
        public int PokeID
        {
            get { return _pokeId; }
            set 
            { 
                if (value > 0)
                {
                    _pokeId = value;
                }
                else
                {
                    //We will replace this line later on once we learn exceptions
                    throw new ValidationException("PokeID needs to be above 0.");
                }
            }
        }
        
        public string Name { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }

        public List<Ability> Abilities { get; set; }

        //Every time you make a new model, make sure you create a constructor
        //This constructor will be responsible to instantiating other objects as well as setting default values for your othe properties
        public Pokemon()
        {
            PokeID = 1;
            Name = "Ditto";
            Type = "Neutral";
            Abilities = new List<Ability>();
        }

        //Override the tostring method to display object information
        //If you want to display the object information in a string format in multiple places
        //You can access this method by just doing (objectName).ToString()
        public override string ToString()
        {
            return $"===Pokemon Info===\nName:  {Name}\nType: {Type}\nHealth:  {Health}\n==============";
        }
    }
}
