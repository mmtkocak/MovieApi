using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCategoryCommand commnad)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = commnad.CategoryName
            });
            await _context.SaveChangesAsync();
        }
    }
}
