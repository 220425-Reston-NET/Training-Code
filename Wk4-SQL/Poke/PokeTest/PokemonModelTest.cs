using PokeModel;
using Xunit;

namespace PokeTest
{
    public class PokemonModelTest
    {
        //This is how C#/XUnit recognizes that this particular method will be a unit test
        //Data annotations - They just add special metadata information that gives special properties to a particular class member

        /// <summary>
        /// Checks the validation for PokeId and sets with valid data (validData > 0)
        /// </summary>
        [Fact]
        public void PokeId_Should_Set_ValidData()
        {
            //Arrange
            Pokemon pokeObj = new Pokemon();
            int pokeId = 28;

            //Act
            pokeObj.PokeID = pokeId;

            //Assert
            Assert.NotNull(pokeObj.PokeID); 
            Assert.Equal(pokeId, pokeObj.PokeID); 
        }


        /// <summary>
        /// Checks the validation for PokeId and checks if it fails (invalidData < 0)
        /// </summary>
        /// <param name="p_pokeId">The inline data being given</param>
        [Theory]
        [InlineData(-19)]
        [InlineData(-1290)]
        [InlineData(0)]
        [InlineData(-12983)]
        public void PokeId_Should_Fail_Set_InvalidData(int p_pokeId)
        {
            //Arrange
            Pokemon pokeObj = new Pokemon();

            //Act & Assert
            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() => 
                {
                    pokeObj.PokeID = p_pokeId;
                }
            );
        }
    }
}