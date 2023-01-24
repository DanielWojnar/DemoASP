using AutoMapper;
using DemoASP.Models;

namespace DemoASP.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() {
            CreateMap<BookFormInput, Book>();
        }
    }
}
