using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using TestAPI.ApplicationDbContext;
using TestAPI.Dto;
using TestAPI.Models;
using TestAPI.Services.IServices;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly SqlServerDbContext _db;
        private readonly IUploadService uploadService;

        public HomeController(SqlServerDbContext db, IUploadService uploadService)
        {
            _db = db;
            this.uploadService = uploadService;
        }

        //[HttpGet("GetUserData")]
        //public IActionResult GetUserData([FromHeader] string userName)
        //{
        //    return Ok(userName);
        //}

        //[HttpGet]
        //public async Task<List<User>> getA()
        //{
        //     return await _db.Users.ToListAsync();
        //}

        //[HttpGet("user/{name}")]
        //public async Task<User> getUser(string name)
        //{
        //    //return await _db.Users.Where(d => d.Accoutname == name).FirstOrDefaultAsync();
        //}

        //[HttpPost("registeruser")]
        //public async Task<ActionResult<User>> AddContact(User userregister)
        //{   
        //    User contact = new User()
        //    {   
        //        Accoutname = userregister.Accoutname,
        //        Password = userregister.Password,
        //        TypeUser = userregister.TypeUser,
        //        Firstname = userregister.Firstname,
        //        Lastname = userregister.Lastname,
        //        Gender = userregister.Gender,
        //        Birthday = userregister.Birthday,
        //        Faculty = userregister.Faculty,
        //        Branch = userregister.Branch,
        //        Education = userregister.Education,
        //        StatusAccout = userregister.StatusAccout
        //    };

        //    await _db.Users.AddAsync(contact);
        //    await _db.SaveChangesAsync();

        //    return Ok(contact);
        //}

        //[HttpPatch("updateuser/{id}/{password}")]
        //public async Task<ActionResult<User>> UpdateUser(int id,string password)
        //{
        //    User target = await _db.Users.Where(user => user.IdUser == id).FirstOrDefaultAsync();
        //    target.Password = password;
        //    _db.Update(target);
        //    await _db.SaveChangesAsync();

        //    return Ok(target);
        //}

        //[HttpPost("[action]")]
        //public async Task<ActionResult> TestUpload([FromForm] TestUpload testUpload)
        //{
        //    await uploadService.Upload(testUpload.Image, Guid.NewGuid().ToString());
        //    return Ok();
        //}

        //[HttpGet("testgets")]
        //public model Testgets()
        //{
        //    model mod = new model()
        //    {
        //        Sayhi = "Hello ZammonV"

        //    };
        //    return mod;

        //}

        //[HttpGet("[action]")]
        //public Task<ResponseDto<List<MockPendingAuctionModel>>> GetPendingAuction()
        //{
        //    List<MockPendingAuctionModel> MockList = new List<MockPendingAuctionModel>()
        //     {

        //         new MockPendingAuctionModel()
        //         {
        //            title = "title name",
        //            description = "description",
        //            profileimage = "https://cdn.discordapp.com/attachments/681151360305201169/1033781143578873927/302418608_1757199631279919_4575167264398495042_n.jpg",
        //            username = "ibestdk",
        //            image = "https://i-ogp.pximg.net/c/w1200_q80_a2_g1_u1_cr0:0.038:1:0.777/img-master/img/2020/08/06/17/43/06/83484044_p0_master1200.jpg",
        //            price = 4564
        //         }

        //         ,new MockPendingAuctionModel()
        //         {
        //            title = "title name",
        //            description = "description",
        //            profileimage = "https://cdn.discordapp.com/attachments/681151360305201169/1033781143578873927/302418608_1757199631279919_4575167264398495042_n.jpg",
        //            username = "ibestdk",
        //            image = "https://media.discordapp.net/attachments/801331667586383872/1034379383978328134/100950847_p0.png?width=671&height=671",
        //            price = 4564
        //         },
                
        //        new MockPendingAuctionModel()
        //         {
        //            title = "title name",
        //            description = "description",
        //            profileimage = "https://cdn.discordapp.com/attachments/681151360305201169/1033781143578873927/302418608_1757199631279919_4575167264398495042_n.jpg",
        //            username = "ibestdk",
        //            image = "https://media.discordapp.net/attachments/801331667586383872/1034379386704646194/101003773_p0.png?width=865&height=671",
        //            price = 4564
        //         }

        //     };



        //    return Task.FromResult(new ResponseDto<List<MockPendingAuctionModel>>()
        //    {
        //        Data = MockList
        //    });
        //}

        //public class MockPendingAuctionModel
        //{
        //    public string title { get; set; }
        //    public string description { get; set; }
        //    public string profileimage { get; set; }
        //    public string username { get; set; }
        //    public string image { get; set; }
        //    public int price { get; set; }
        //}

        //public class model
        //{
        //    public string Sayhi { get; set; }
        //}

        //public class ResponseDto<T>
        //{
        //    public bool Success { get; set; }
        //    public string Message { get; set; }
        //    public T Data { get; set; }
        //}
    }
}

