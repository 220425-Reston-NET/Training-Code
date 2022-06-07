using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class StoreBL : IStoreBL
    {
        private IRepository<Store> _storeRepo;
        public StoreBL(IRepository<Store> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }

        public List<Product> ViewStoreInventory(int p_sId)
        {
            List<Store> listOfCurrentStore = _storeRepo.GetAll();

            foreach (Store item in listOfCurrentStore)
            {
                //Condition to return a specific store
                if (item.Id == p_sId)
                {
                    return item.Products;
                }
            }

            //It will return nothing if the client specify a store that was never in the database
            return null;
        }
    }
}