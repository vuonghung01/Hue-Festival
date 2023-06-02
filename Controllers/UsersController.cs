using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hue_Festival;
using Hue_Festival.Models;
using System.Security.Cryptography;

namespace Hue_Festival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly HueFestivalContext _context;

        public UsersController(HueFestivalContext context)
        {
            _context = context;
        }

        // Dang ky
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest req)
        {
            if (_context.Users.Any(u => u.Email == req.Email))
            {
                return BadRequest("Người dùng đã tồn tại.");
            }

            var user = new User
            {
                Email = req.Email,
                Password = req.Password,
                VerificationToken = CreateRandomToken()
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("Tạo tài khoản thành công!");
        }

        // Dang nhap
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserRegisterRequest req)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == req.Email);
            if (user == null)
            {
                return BadRequest("Người dùng không tồn tại.");
            }

            if (user.Password != req.Password)
            {
                return BadRequest("Mật khẩu không đúng!");
            }

            if (user.VerifiedAt == null)
            {
                return BadRequest("Người dùng chưa xác thực!");
            }

            return Ok($"Đăng nhập thành công, {user.Email}");
        }

        // Xac thuc tai khoan
        [HttpPost("verify")]
        public async Task<IActionResult> Verify(string token)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.VerificationToken == token);
            if (user == null)
            {
                return BadRequest("Token không hợp lệ.");
            }

            user.VerifiedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return Ok("Xác thực tài khoản thành công!");
        }

        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
