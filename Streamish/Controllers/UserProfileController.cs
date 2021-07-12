//using Microsoft.AspNetCore.Mvc;
//using Streamish.Repositories;
//using Streamish.Models;
//using System;

//namespace Streamish.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserProfileController : ControllerBase
//    {
//        private readonly IUserProfileRepository _userProfileRepository;
//        public UserProfileController(IUserProfileRepository userProfileRepository)
//        {
//            _userProfileRepository = userProfileRepository;
//        }

//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(_userProfileRepository.GetAll());
//        }

//        [HttpGet("{id}")]
//        public IActionResult Get(int id)
//        {
//            var userProfile = _userProfileRepository.GetById(id);
//            // created getbyid method
//            if(userProfile == null)
//            {
//                return NotFound();
//            }
//            return Ok(userProfile);
//        }

//        [HttpPost]
//        public IActionResult Post(UserProfile userProfile)
//        {
//            _userProfileRepository.Add(userProfile);
//            return CreatedAtAction("Get", new { id = userProfile.Id }, userProfile);
//        }
//    }
//}
