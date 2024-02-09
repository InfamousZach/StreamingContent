namespace StreamingContent_Repository;

public class StreamingContentRepository
{
    protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // Create
    public bool AddContentToDirectory(StreamingContent content)
    {
        int startingCount = content.Count();
        _contentDirectory.Add(content);
        bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
        return wasAdded;
    }

    // Read
    public List<StreamingContent> GetContents()
    {
        return _contentDirectory;
    }

    public StreamingContent GetContentByTitle(string title)
    {
        foreach (StreamingContent content in _contentDirectory)
        {
            if (content.Title.ToLower() == title.ToLower())
            {
                return content;
            }
        }
        return null;
    }

    // Update
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
{
    StreamingContent oldContent = GetContentByTitle(originalTitle);
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

// Delete
public bool DeleteExistingContent(StreamingContent existingContent)
{
    bool deleteResult = _contentDirectory.Remove(existingContent);
    return deleteResult;
}
} 