namespace StreamingContent_Repository;

public class Show : StreamingContent {

    public Show(){} 

    public Show(string title, string description, MaturityRating maturityRating, double stars, GenreType genre){
        Title = title;
        Description = description;
        MaturityRating = maturityRating;
        StarRating = stars;
        TypeOfGenre = genre;
    } 
    // Refactor the AverageRunTime property to use the Episodes property.
    public double AverageRunTime { 
        get
        {
            double total = 0;
            double AverageRunTime = 0;
            // Total = Add all run times together 
            foreach(Episode episode in Episodes)
            {
                total = total + episode.RunTime;
                Console.WriteLine(total);
            }
            // Avrage runtime = total / divide by number of episodes
        AverageRunTime = total / Episodes.Count;
        return AverageRunTime;
        } 
} 
public List<Episode> Episodes { get; set; } = new List<Episode>();
}
public class Episode {
    public string Name { get; set; }
    public double RunTime { get; set; }
} 
