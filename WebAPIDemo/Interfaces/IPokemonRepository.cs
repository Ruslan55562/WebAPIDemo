using WebAPIDemo.Models;

namespace WebAPIDemo.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
