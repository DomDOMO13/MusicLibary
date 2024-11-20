
using Microsoft.EntityFrameworkCore;
using musicplayer.Database;

namespace musicplayer;

public class AppContext : DbContext
{

	public DbSet<User> Users { get; set; }
	public DbSet<Song> Songs {get; set;}

	private String dbpath;

	public AppContext()
	{
		var folder = Environment.SpecialFolder.LocalApplicationData;
		var path = Environment.GetFolderPath(folder);
		this.dbpath = System.IO.Path.Join(path, "music.db");
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
			 => options.UseSqlite($"Data Source={this.dbpath}");

}