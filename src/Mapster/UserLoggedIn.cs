using Mapster;

namespace AutoMapperTest.Mapster
{
	[AdaptTo("UserObject"), GenerateMapper]
	public record UserLoggedIn
    {
        public Guid UserId { get; init; }
        public Guid Session { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }

        public static explicit operator UserLoggedIn(UserObject user)
            => user.Adapt<UserLoggedIn>();
    }
}