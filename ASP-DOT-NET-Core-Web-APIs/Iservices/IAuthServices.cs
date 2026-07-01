using ASP_DOT_NET_Core_Web_APIs.DTO;

namespace ASP_DOT_NET_Core_Web_APIs.Iservices
{
    public interface IAuthServices
    {
        Task<Tuple<int, string>> LoginUser(UserDto dto);
    }
}
