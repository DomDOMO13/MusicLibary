using Microsoft.EntityFrameworkCore;
using musicplayer.Database;

namespace musicplayer.services;

public interface ILibraryService
{

	void AddSong(Song song);

	bool Delete(int songId);

	void UpdateSong(int songId, Song song);

	List<Song> SearchByTitle(String keyterm);

}

public class LibraryService : ILibraryService
{

	private AppContext context;

	public LibraryService(AppContext context)
	{
		this.context = context;
	}

	public void AddSong(Song song)
	{
		this.context.Songs.Add(song);
		this.context.SaveChanges();
	}


	private Song FindById(int id)
	{
		return this.context.Songs.SingleOrDefault(x => x.Id == id);
	}

	public bool Delete(int songId)
	{
		var song = FindById(songId);
		if (song != null)
		{
			this.context.Songs.Remove(song);
			this.context.SaveChanges();
			return true;
		}

		return false;
	}

	public List<Song> SearchByTitle(string keyterm)
	{
		var list = this.context.Songs.Where(x => x.Title.Contains(keyterm)).AsNoTracking().ToList();
		return list;
	}

	public void UpdateSong(int songId, Song song)
	{
		var foundSong = FindById(songId);
		if (foundSong != null)
		{
			song.Id = foundSong.Id;
			this.context.Songs.Update(song);
			this.context.SaveChanges();
		}
	}
}