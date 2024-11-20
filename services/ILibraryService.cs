using Microsoft.EntityFrameworkCore;
using musicplayer.Database;

namespace musicplayer.services;

public interface ILibraryService
{

	Song AddSong(Song song);

	bool Delete(String songId);

	void UpdateSong(String songId, Song song);

	List<Song> SearchByTitle(String keyterm);

}

public class LibraryService : ILibraryService
{

	private AppContext context;

	public LibraryService(AppContext context)
	{
		this.context = context;
	}

	public Song AddSong(Song song)
	{
		this.context.Songs.Add(song);
		this.context.SaveChanges();

		return FindById(song.Id);
	}


	private Song FindById(String id)
	{
		return this.context.Songs.SingleOrDefault(x => x.Id == id);
	}

	public bool Delete(string songId)
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

	public void UpdateSong(string songId, Song song)
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