using AutoMapper;

namespace AutoMapperTest.AutoMapper
{
    public static class Mapper
    {
        private static readonly MapperConfiguration config = new(cfg =>
            cfg.CreateMap<UserObject, UserLoggedIn>()
        );

        public static readonly IMapper mapper = config.CreateMapper();
    }
}