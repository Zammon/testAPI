using System.Net;
using TestAPI.Services.IServices;

namespace TestAPI.Services
{
    public class UploadService : IUploadService
    {
        public async Task Upload(IFormFile image, string fileName)
        {
            var ext = Path.GetExtension(image.FileName);
            FtpWebRequest ftp = (FtpWebRequest)WebRequest.Create($"ftp://119.59.96.90/ImagePosts/{fileName}{ext}");
            ftp.Credentials = new NetworkCredential("ftp_dropsideway", "xzbG76*61");
            ftp.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream stream = ftp.GetRequestStream())
            {
                image.CopyTo(stream);
            }
        }
    }
}
