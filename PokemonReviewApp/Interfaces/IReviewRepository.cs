using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int Reviewid);
        ICollection<Review> GetReviewsOfAPokemon(int PokemonId);
        bool ReviewExists(int Reviewid);
    }
}
