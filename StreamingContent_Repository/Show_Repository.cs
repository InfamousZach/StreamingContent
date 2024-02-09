namespace StreamingContent_Repository{

public class Show_Repository {
        protected readonly List<Show> _contentDirectory = new List<Show>();

    // Add Show

    public bool AddContentToDirectory(Show content)
    {
        int startingCount = _contentDirectory.Count();
        _contentDirectory.Add(content);
        bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
        return wasAdded;
    }

    // Get All Shows
    public List<Show> GetContents()
    {
        return _contentDirectory;
    }
    public Show GetContentByTitle(string title)
    {
        foreach (Show content in _contentDirectory)
        {
            if (content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
    }

    // Get all family friendly shows
    public List<Show> GetContentByFamilyFriendly()
    {
        List<Show> familyFriendlyShows = new List<Show>();
        foreach (Show currentShow in _contentDirectory)
        {
            if (currentShow.IsFamilyFriendly == true)
            {
             familyFriendlyShows.Add(currentShow);
            }
        }
        return familyFriendlyShows;
    }

    // Update Show from userInput:
    public void updateShow(int ShowId, Show newContent)
{
    _contentDirectory[ShowId] = newContent;
}

// Update Show:
    public bool UpdateExistingContent(string originalTitle, Show newContent)
{
    Show oldContent = GetContentByTitle(originalTitle);
    if(oldContent != null)
    {
        oldContent.Title = newContent.Title;
        oldContent.Description = newContent.Description;
        oldContent.StarRating = newContent.StarRating;
        oldContent.MaturityRating = newContent.MaturityRating;
        oldContent.TypeOfGenre= newContent.TypeOfGenre;
        return true;
    }
    else
    {
        return false;
    }
}

// DeleteShow
public bool DeleteExistingContent(Show existingContent)
{
    bool deleteResult = _contentDirectory.Remove(existingContent);
    return deleteResult;
}

// Delete Show by ID:
public bool DeleteShowbyId(int showRemoveal){
    int startingCount = _contentDirectory.Count;
    _contentDirectory.RemoveAt(showRemoveal);
    bool wasDeleted = (_contentDirectory.Count <startingCount) ? true : false;
    return wasDeleted;
}
}
}
