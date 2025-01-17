using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.Categories;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.DTOs.ResponseDTOs;

namespace ArgentoApp.Business.Abstract;

public interface ICategoryService
{
     Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);
     Task<ResponseDto<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
     Task<ResponseDto<NoContent>> DeleteAsync(int id);
     Task<ResponseDto<CategoryDto>> GetAsync(int id);
     Task<ResponseDto<List<CategoryDto>>> GetAllAsync();
     Task<ResponseDto<List<CategoryDto>>> GetActivesAsync(bool isActive = true);
     Task<ResponseDto<int>> GetCountAsync();
     Task<ResponseDto<int>> GetActivesCountAsync(bool isActive = true);
}

