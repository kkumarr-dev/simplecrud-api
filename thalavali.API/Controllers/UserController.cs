using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thalavali.API;
using thalavali.API.Entities;

namespace thalavali.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ThalavaliDbContext _dbContext;
        public UserController(ThalavaliDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("Get")]
        public IActionResult GetUsers()
        {
            var user = _dbContext.TblUsers.ToList();
            return Ok(user);
        }

        [HttpPost("Save")]
        public IActionResult SaveUser(UserViewModel user)
        {
            var res = false;
            if (user != null)
            {
                var obj = new TblUsers
                {
                    username = user.Username,
                    phonenumber = user.Phonenumber
                };
                _dbContext.TblUsers.Add(obj);
                res = _dbContext.SaveChanges() > 0;
            }
            return Ok(res);
        }
        
        [HttpPost("update")]
        public IActionResult updateUser(UserViewModel user)
        {
            var res = false;
            var checkdata = _dbContext.TblUsers.Where(x => x.Userid == user.Userid).FirstOrDefault();
            if (checkdata != null)
            {
                checkdata.username = user.Username;
                checkdata.phonenumber = user.Phonenumber;
                _dbContext.TblUsers.Update(checkdata);
                res = _dbContext.SaveChanges() > 0;
            }
            return Ok(res);
        }
        [HttpPost("delete")]
        public IActionResult deleteUser(int userid)
        {
            var res = false;
            var checkdata = _dbContext.TblUsers.Where(x => x.Userid == userid).FirstOrDefault();
            if (checkdata != null)
            {
                _dbContext.TblUsers.Remove(checkdata);
                res = _dbContext.SaveChanges() > 0;
            }
            return Ok(res);
        }
    }
}
