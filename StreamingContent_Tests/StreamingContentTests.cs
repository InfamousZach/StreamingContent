using StreamingContent_Repository;

namespace StreamingContent_Tests;

[TestClass]
public class StreamingContentTests
{
    [TestMethod]
    public void SetTitle_ShouldSetCorrectString(){
        StreamingContent content = new StreamingContent();
    
            content.Title = "Toy Story";
        string expected = "Toy Story";
        string actual = content.Title;
        Assert.AreEqual(expected,actual);
    }
    // testing for description 
    [TestMethod]
    public void setDescripton_ShouldSetCorrectString(){
        StreamingContent content = new StreamingContent();

            content.Description = "Toy Story is an animated film";
        string expected = "Toy Story is an animated film";
        string actual = content.Description;
        Assert.AreEqual(expected,actual);
    }
    // testing for rating
    [TestMethod]
    public void TestMethod1() {
        StreamingContent content = new StreamingContent();
            content.StarRating = 4.5;
        Assert.AreEqual(4.5,content.StarRating);

    }
    // Maturity range
    [DataTestMethod]
    [DataRow(MaturityRating.G,true)]
    [DataRow(MaturityRating.PG,true)]
    [DataRow(MaturityRating.PG_13,true)]
    [DataRow(MaturityRating.R,false)]
    public void SetMaturityRating_ShouldGetCorrectFamilyFriendliness(MaturityRating rating, bool expectedFamilyFriendly)
    {
        // Triple A Paradigm, a short hand for setting up tests
        
        // Arrange => Setting the stage
        StreamingContent content = new StreamingContent("Content Title","Some description", rating, 4.2, GenreType.SciFi);
        
        // Act => We're executing any code that we need to run
        // If there were methods to call or properties to set, we'd do that here
        bool actual = content.IsFamilyFriendly;
        bool expected = expectedFamilyFriendly;
        
        // Assert => We're calling our asssertions finally
        Assert.AreEqual(expected, actual);
    }
}
