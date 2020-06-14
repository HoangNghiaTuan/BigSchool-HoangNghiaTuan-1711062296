using BigSchool_HoangNghiaTuan_1711062296.DTOs;
using BigSchool_HoangNghiaTuan_1711062296.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool_HoangNghiaTuan_1711062296.Controllers.Api
{
    public class FollowingsController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Cancel(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if(_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
            {
                return BadRequest("Following already exists!");
            }
            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };

            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
