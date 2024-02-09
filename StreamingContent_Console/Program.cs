using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreamingContent_Repository;

namespace StreamingContent_UI
{

public class UIHelper {
    Movie_Repository  movieList = new Movie_Repository();
    public void AddingNewMovies(){
    Movie NewMovie = new Movie();
    Console.WriteLine("Type a movie you want to add"); // Enter movie title
    string AddMovieContent = Console.ReadLine();
    Console.WriteLine("Enter the directors name for this movie"); // enter directors name for movie
    string addMovieDirector = Console.ReadLine();
    Console.WriteLine("Enter the movie Star rating"); // Add runtime for new movie
    double addMovieStarRating = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("You added a movie " + AddMovieContent + " " + "A director " + addMovieDirector + " " + "And the Star Rating " + addMovieStarRating); // Complete added movie
    NewMovie.Title = AddMovieContent;
    NewMovie.Director = addMovieDirector;
    NewMovie.RunTime = addMovieStarRating;
    bool AddMovie = movieList.AddMovieContent(NewMovie);
}

    public void ListofMovies(){
        List<Movie> MovieList = movieList.GetContents();
        Console.WriteLine("Movie List" + MovieList.Count);
        foreach (Movie LiMovie in MovieList)
        {
            Console.WriteLine(" Movie Name: " + LiMovie.Title + " | " + "Movie Director: " + LiMovie.Director + " | " + " Movie RunTime: " + LiMovie.RunTime);
        }
        Console.WriteLine("======================================================");
    }

public void DeleteMovies(){
    Console.WriteLine("Type the number that corisponds to the movie you would like to delete."); // User has to enter number to select and delete.
    List<Movie> MovieList = movieList.GetContents();
    for (int i = 0; i < MovieList.Count; i++){
        Console.WriteLine(i + " " + MovieList[i].Title);
    }
    // call delete movie method from repository
    int deleteUserInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Deleting Movie # " + deleteUserInput);
    bool DeleteMoviebyId = movieList.DeleteMoviebyId(deleteUserInput);
}
public void updateMovies(){
    Console.WriteLine("Type the number next to the movie you would like to update.");
    List<Movie> MovieList = movieList.GetContents();
    for (int i = 0; i < MovieList.Count; i++ ){
        Console.WriteLine(i + MovieList[i].Title);
    }
    int updateMovieInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type 1 to update the movie Title");
    Console.WriteLine("Type 2 to update the movie Director");
    Console.WriteLine("Type 3 to update the movie star rating");

    int updateMovieInput1 = Convert.ToInt32(Console.ReadLine());
    if (updateMovieInput1 == 1){
        Console.WriteLine("updating movie Title");
    }
    else if (updateMovieInput1 == 2){
        Console.WriteLine("updating movie Director");
    }
    else if (updateMovieInput1 == 3){
        Console.WriteLine("updating movie star rating");
    }

    string userUpdate = Console.ReadLine();
    Movie Bla = new Movie(); 
       if (updateMovieInput1 == 1){
        Bla.Title = userUpdate;
    }
    else if (updateMovieInput1 == 2){
        Bla.Director = userUpdate;
    }
    else if (updateMovieInput1 == 3){
        Bla.StarRating = Convert.ToDouble(userUpdate);
    } 
    movieList.updateMovie(updateMovieInput, Bla);
    return;
} 
// Add a Show 
Show_Repository showList = new Show_Repository();
public void AddingNewShows(){
Show NewShow = new Show();
Console.WriteLine("Enter a show you want to add"); // Enter Show title
string AddContentToDirectory = Console.ReadLine();
Console.WriteLine("Enter show description"); // Enter the shows descrtiption
string addShowDescription = Console.ReadLine();
Console.WriteLine("You added a Show" + AddContentToDirectory + " " + "A Description" + addShowDescription); // Complete added show
NewShow.Title = AddContentToDirectory;
NewShow.Description = addShowDescription;
bool AddShow = showList.AddContentToDirectory(NewShow);
}
// go back later and add seprate page episodes to get AVG run time!!!

// List of Shows
public void ListofShows(){
    List<Show> ShowList = showList.GetContents();
    Console.WriteLine("Show List" + ShowList.Count);
    foreach(Show LiShow in ShowList){
        Console.WriteLine(" Show Name: " + LiShow.Title + " | " + " Show Description: " + LiShow.Description);
    }
    Console.WriteLine("============================================================");
}

// Delete Shows
public void DeleteShows(){
Console.WriteLine("Type the number that corisponds to the Show you would like to delete.");
List<Show> ShowList = showList.GetContents();
for (int i = 0; i < ShowList.Count; i++){
        Console.WriteLine(i + " " + ShowList[i].Title);
    }
int deleteUserInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Deleting Show # " + deleteUserInput);
    bool DeleteShowbyId = showList.DeleteShowbyId(deleteUserInput);
} 
// Update Shows 
public void updateShows(){
    Console.WriteLine("Type the number next to the show you would like to update.");
    List<Show> ShowList = showList.GetContents();
    for (int i = 0; i < ShowList.Count; i++ ){
        Console.WriteLine(i + ShowList[i].Title);
    }
    int updateShowInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type 1 to update the show Title");
    Console.WriteLine("Type 2 to update the show Description");

    int updateShowInput1 = Convert.ToInt32(Console.ReadLine());
    if (updateShowInput1 == 1){
        Console.WriteLine("updating Show Title");
    }
    else if (updateShowInput1 == 2){
        Console.WriteLine("updating Show Description");
    }

    string userUpdate = Console.ReadLine();
    Show Bla1 = ShowList[updateShowInput];
       if (updateShowInput1 == 1){
        Bla1.Title = userUpdate;
    }
    else if (updateShowInput1 == 2){
        Bla1.Description = userUpdate;
    } 
    showList.updateShow(updateShowInput, Bla1);
    return;
}
public class Program{
public static void Main(string[] args){

UIHelper uih = new UIHelper();

// display menu
while(true){
Console.WriteLine("--->Streaming Content Application<---");
Console.WriteLine("=====================================");
Console.WriteLine("Enter letter or numbernext to menu item");
Console.WriteLine("");

// Movie
Console.WriteLine("MOVIE");
Console.WriteLine("A. Add a Movie");
Console.WriteLine("B. List of Movies");
Console.WriteLine("C. Update a Movie");
Console.WriteLine("D. Delete a Movie");
Console.WriteLine("");

// Show
Console.WriteLine("Show");
Console.WriteLine("E. Add a Show");
Console.WriteLine("F. List of Shows");
Console.WriteLine("G. Update a Show");
Console.WriteLine("H. Delete a Show");

// Exit application
Console.WriteLine("Exit!");
Console.WriteLine("x. Exit Application");
Console.WriteLine("");
Console.WriteLine("=====================================");
// get ueser input, key pressed
string menuInput = Console.ReadLine().ToLower();

Console.WriteLine("menu input = " + menuInput);

// Go take indicated action
switch(menuInput) {
case "a": // Adding Movie
    Console.WriteLine("Adding a movie");
    uih.AddingNewMovies();
    break;
case "b": // List of movies
    Console.WriteLine("Listing movies");
    uih.ListofMovies();
    break;
case "d": // Delete a movie
    Console.WriteLine("Deleting a movie");
    uih.DeleteMovies();
    break;
case "c": // Update a movie
    Console.WriteLine("Update a movie");
    uih.updateMovies();
    break;
case "e": // Adding Show
    Console.WriteLine("Adding a show");
    uih.AddingNewShows();
    break;
case "f": // List of Shows
    Console.WriteLine("Listing Shows");
    uih.ListofShows();
    break;
case "h": // Delete Shows
    Console.WriteLine("Delete Shows");
    uih.DeleteShows();
    break;
case "g": // Update Show
    Console.WriteLine("Updtae Shows");
    uih.updateShows();
    break;
case "x": // Exit app
    Console.WriteLine("Exit application");
    return;
    break;
                }
        }
}
}
}
}