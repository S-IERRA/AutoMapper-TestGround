namespace AutoMapperTest.AutoMapper
{
    //Removed password property
    public record UserLoggedIn
    {
        public Guid UserId { get; init; }
        public Guid Session { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }

        //Maps user -> userDTo and strips the password property
        public static explicit operator UserLoggedIn(UserObject user)
        {
            return Mapper.mapper.Map<UserLoggedIn>(user);
        }
    }
}