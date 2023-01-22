namespace AutoMapperTest.Objects
{
	public record UserObject
	{
		public required Guid UserId { get; init; }
		public Guid? Session { get; set; }

		public required string Name { get; set; }
		public required string Password { get; set; } //Cannot be sent over
		public required string Email { get; set; }
	}
}
