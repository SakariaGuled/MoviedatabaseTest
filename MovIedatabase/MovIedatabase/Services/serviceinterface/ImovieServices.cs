using MovIedatabase.Entities.DTO;

namespace MovIedatabase.Services.serviceinterface
{
    public interface ImovieServices
    {
        public Task<ICollection<MovieDTO>> GetAllMovies();
        public Task<MovieDTO> GetMovieById(int id);
        public Task<MovieDTO> DeleteById(int id);

    }
}
