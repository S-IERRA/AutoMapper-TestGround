using AutoMapper;
using AutoMapperTest.Mapster;

using Mapster;

UserObject user = new()
{
	UserId = Guid.NewGuid(),

	Name = "Test",
	Password = "Password",
	Email = "Test@gmail.com"
};

var userDTo = (UserLoggedIn)user;

Console.WriteLine(user.ToString());
Console.WriteLine(userDTo.ToString());