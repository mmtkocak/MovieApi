using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateMovieCommand commnad)
        {
            _context.Movies.Add(new Movie
            {
                CoverImageUrl = commnad.CoverImageUrl,
                CreatedYear = commnad.CreatedYear,
                Description = commnad.Description,
                Duration = commnad.Duration,
                Rating = commnad.Rating,
                ReleaseDate = commnad.ReleaseDate,
                Status = commnad.Status,
                Title = commnad.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
