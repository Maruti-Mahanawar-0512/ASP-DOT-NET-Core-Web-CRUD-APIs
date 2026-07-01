using ASP_DOT_NET_Core_Web_APIs.Data;
using ASP_DOT_NET_Core_Web_APIs.DTO;
using ASP_DOT_NET_Core_Web_APIs.Iservices;
using Microsoft.EntityFrameworkCore;

namespace ASP_DOT_NET_Core_Web_APIs.Services
{
    public class AuthServices:IAuthServices
    {
        private readonly AppDbContext _context;
        public AuthServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Tuple<int, string>> LoginUser(UserDto dto)
        {
            try
            {
                var ExistingUser = await _context.AccountUsers.FirstOrDefaultAsync(x => x.Email == dto.Email);
                if(ExistingUser == null)
                {
                    return new Tuple<int, string>(0,"User Not Found, Pleaee login.");
                }
                if(ExistingUser.Password != dto.Password)
                {
                    return new Tuple<int, string>(1, "Password is incorrect.");
                }
                return new Tuple<int, string>(2, "Login Successful.");

            }
            catch (Exception)
            {
                return new Tuple<int, string>(3, "Something Went Wrong");
            }
        }
    }
}
