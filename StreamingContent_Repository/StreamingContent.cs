
namespace StreamingContent_Repository;

public class StreamingContent
{
        public StreamingContent() {}
    
    public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType genre)
    {
        Title = title;
        Description = description;
        MaturityRating = maturityRating;
        StarRating = stars;
        TypeOfGenre = genre;
    }
    public string Title {get; set;}
    public string Description {get; set;}
    public double StarRating {get; set;}
    public MaturityRating MaturityRating {get; set;}
    public bool IsFamilyFriendly {
        get {
            switch(MaturityRating){
                case MaturityRating.G:
                Console.WriteLine($"This movie is rated G");
                return true;
                case MaturityRating.PG:
                Console.WriteLine($"This movie is rated PG");
                return true;
                case MaturityRating.PG_13:
                Console.WriteLine($"This movie is rated PG-13");
                return true;
            default:
                Console.WriteLine($"This movie is rated R!");
                return false;
            }
        }
    }

    public GenreType TypeOfGenre {get; set;}

    internal int Count()
    {
        throw new NotImplementedException();
    }
}
public enum GenreType
{
    Horror = 1,
    RomCom,
    SciFi,
    Documentary,
    Bromance,
    Drama,
    Action,
    Fantasy
} 

public enum MaturityRating { 
    G,
    PG,
    PG_13,
    R
}
