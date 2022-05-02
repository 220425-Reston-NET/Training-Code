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
                    Console.WriteLine("Pokemon ID can only hold positive numbers! ( value > 0 )");
                }
            }
        }
        
        public string Name { get; set; }
        public string Type { get; set; }

    }
}
