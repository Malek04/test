using AutoMapper;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(DataContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        } 
        public Review GetReview(int Reviewid)
        {
            return _context.Reviews.Where(r => r.Id == Reviewid).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsOfAPokemon(int PokemonId)
        {
            return _context.Reviews.Where(r=>r.Pokemon.Id == PokemonId).ToList();
        }

        public bool ReviewExists(int Reviewid)
        {
            return _context.Reviews.Any(r=>r.Id == Reviewid);
        }
    }
}
