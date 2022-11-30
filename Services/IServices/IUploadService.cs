namespace TestAPI.Services.IServices
{
    public interface IUploadService
    {
        Task Upload(IFormFile image, string fileName);
    }
}
