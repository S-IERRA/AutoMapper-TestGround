using AutoMapper;

using AutoMapperTest.Objects;


UserObject user = new()
{
	UserId = Guid.NewGuid(),

	Name = "Test",
	Password = "Password",
	Email = "Test@gmail.com"
};

UserLoggedIn userDTo = (UserLoggedIn)user;

Console.WriteLine(user.ToString());    // Has password property
Console.WriteLine(userDTo.ToString()); // Stripped of password property