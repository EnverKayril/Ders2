namespace _16_MVC_DependencyInjection.Services.Abstract
{
    public interface IProductService
    {
        void GetAllProducts();
        void GetById(int id);
        void GetByName(string name);
        void Create();
        void Update();
        void Delete();
    }
}
