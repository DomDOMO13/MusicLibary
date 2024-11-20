using musicplayer.Database;

namespace musicplayer.services;

public interface IUserService
{

	User Login(String username, String password);

}

public class UserService : IUserService
{
	private AppContext appContext;

	public UserService(AppContext appContext)
	{
		this.appContext = appContext;
	}


	public User Login(string username, string password)
	{
		var user = this.appContext.Users.Where(x => x.Username.SequenceEqual(username)).SingleOrDefault();
		if(user == null) {
			throw new Exception("Password or Username incorrect");
		}

		if(!user.Password.SequenceEqual(password)) {
			throw new Exception("Password or Username incorrect");
		}

		return user;
	}

	public User Regsiter(String username, String password)
	{
		var found = appContext.Users.Where(x => x.Username.SequenceEqual(username));
		if(found != null) {
			throw new Exception("username is already taken");
		}

		var user = new User();
		user.Username = username;
		user.Password = password;

		this.appContext.Users.Add(user);
		this.appContext.SaveChanges();

		var newUser = this.appContext.Users.Where(x => x.Username.SequenceEqual(username)).SingleOrDefault();
		return newUser;
	}
}