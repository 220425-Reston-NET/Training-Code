using PokeModel;

namespace PokeBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// Will display the list of products from a store
        /// </summary>
        /// <param name="p_sId">This is the store it will select</param>
        /// <returns>Gives a list of product from that store</returns>
        public List<Product> ViewStoreInventory(int p_sId);
    }
}