using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace TestAutomapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Using default Mapper configuration
            User user = new User()
            {
                Age = 10,
                Citizenship = "lol",
                Name = "Siarhei Mahlysh"
            };

            IMapper mapper = new Mapper(
                new MapperConfiguration(
                    conf =>
                    {
                       // conf.CreateMap<User, UserDTO>()
                       //     .ForMember(d => d.FirstName, opt => opt.MapFrom(u => u.Name.Split(' ')[0]))
                       //     .ForMember(d => d.LastName, opt => opt.MapFrom(u => u.Name.Split(' ')[1]));
                        conf.AddProfile<UserProfile>();
                    })
                );

            UserDTO userDto = mapper.Map<UserDTO>(user);
        }
    }
}
