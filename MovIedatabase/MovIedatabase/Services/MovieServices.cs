using MovIedatabase.Entities.DTO;
using MovIedatabase.Services.serviceinterface;

namespace MovIedatabase.Services
{
    public class MovieServices : ImovieServices
    {
        public Task<MovieDTO> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<MovieDTO>> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Task<MovieDTO> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
