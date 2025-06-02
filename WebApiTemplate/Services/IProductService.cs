using WebApiTemplate.DTOs;

namespace WebApiTemplate.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto?> GetByIdAsync(int id);
        Task<ProductDto> CreateAsync(CreateProductDto createProductDto, string userId);
        Task<ProductDto?> UpdateAsync(int id, UpdateProductDto updateProductDto, string userId);
        Task<bool> DeleteAsync(int id);
    }
}