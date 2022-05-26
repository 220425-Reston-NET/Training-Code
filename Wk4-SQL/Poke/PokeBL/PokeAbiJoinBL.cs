using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class PokeAbiJoinBL : IPokeAbiJoinBL
    {
        //========================================
        private IRepository<PokemonAbilityJoin> _pokeAbiRepo;
        public PokeAbiJoinBL(IRepository<PokemonAbilityJoin> p_pokeAbiRepo)
        {
            _pokeAbiRepo = p_pokeAbiRepo;
        }
        //=======================================

        public void ReplenishAbilityPP(int p_PP, int p_abId, int p_pokeId)
        {
            PokemonAbilityJoin joinTable = new PokemonAbilityJoin();
            joinTable.abId = p_abId;
            joinTable.PP = p_PP;
            joinTable.pokeId = p_pokeId;

            //Logic to check if the pokemon even exist

            _pokeAbiRepo.Update(joinTable);
        }
    }
}