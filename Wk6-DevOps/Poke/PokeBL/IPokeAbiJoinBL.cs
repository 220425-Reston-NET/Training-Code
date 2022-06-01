namespace PokeBL
{
    public interface IPokeAbiJoinBL
    {
        /// <summary>
        /// This will replenish the PP of a pokemon's ability
        /// </summary>
        /// <param name="p_PP">This is the PP amount it will replenish</param>
        /// <param name="p_abId">This is the ability that it will replenish</param>
        /// <param name="p_pokeId">This is the pokemon that has that ability that will replenish</param>
        void ReplenishAbilityPP(int p_PP, int p_abId, int p_pokeId);
    }
}