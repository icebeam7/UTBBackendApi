namespace UTBBackendApi.Services
{
    public interface IDbService
    {
        Task<List<T>> GetAll<T>() where T : class;
        Task<T> Get<T>(int id) where T : class;
        Task Add<T>(T newData);
    }
}
