using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingContent_Repository
{
    public class Movie_Repository {
    protected readonly List<Movie> _contentDirectory = new List<Movie>();

           // Add Movie:

    public bool AddMovieContent(Movie content)
    {
        int startingCount = _contentDirectory.Count();
        _contentDirectory.Add(content);
        bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
        return wasAdded;
    }

        // Get All Movies:
    public List<Movie> GetContents()
    {
        return _contentDirectory;
    }
    public Movie GetContentByTitle(string title)
    {
        foreach (Movie content in _contentDirectory)
        {
            if (content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
    }

    // Get all family friendly Movies:
    public List<Movie> GetContentByFamilyFriendly()
    {
        List<Movie> familyFriendlyMovie = new List<Movie>();
        foreach (Movie currentMovie in _contentDirectory)
        {
            if (currentMovie.IsFamilyFriendly == true)
            {
             familyFriendlyMovie.Add(currentMovie);
            }
        }
        return familyFriendlyMovie;
    }

// Update Movie:
    public void updateMovie(int movieId, Movie newContent)
{
    _contentDirectory[movieId] = newContent;
}

// Delete Movie:
public bool DeleteExistingContent(Movie existingContent)
{
    bool deleteResult = _contentDirectory.Remove(existingContent);
    return deleteResult;
}

// Delete Movie by ID:
public bool DeleteMoviebyId(int movieRemoveal){
    int startingCount = _contentDirectory.Count;
    _contentDirectory.RemoveAt(movieRemoveal);
    bool wasDeleted = (_contentDirectory.Count <startingCount) ? true : false;
    return wasDeleted;
}
}
}