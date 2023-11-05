using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The 3 steps to any good unitTest
// Arrange, Act, Assert

namespace DemoLibrary.Tests;
public class DisplayMessagesTests
{
    [Fact]
    public void GreetingShouldReturnGoodMorningMessage()
    {
        // Arrange
        DisplayMessages messages = new DisplayMessages();
        string? expected = "Go to bed David";

        // Act
        string actual = messages.Greeting("David", 3);

        //Assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void GreetingShouldReturnGoodAfternoonMessage()
    {
        // Arrange
        DisplayMessages messages = new DisplayMessages();
        string? expected = "Good afternoon David";

        // Act
        string actual = messages.Greeting("David", 14);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("David", 0, "Go to bed David")]
    [InlineData("David", 1, "Go to bed David")]
    [InlineData("David", 2, "Go to bed David")]
    [InlineData("David", 3, "Go to bed David")]
    [InlineData("David", 4, "Go to bed David")]
    [InlineData("David", 5, "Good morning David")]
    [InlineData("David", 6, "Good morning David")]
    [InlineData("David", 7, "Good morning David")]
    [InlineData("David", 8, "Good morning David")]
    [InlineData("David", 9, "Good morn ing David")]
    [InlineData("David", 10, "Good morning David")]
    [InlineData("David", 11, "Good morning David")]
    [InlineData("David", 12, "Good afternoon David")]
    [InlineData("David", 13, "Good afternoon David")]
    [InlineData("David", 14, "Good afternoon David")]
    [InlineData("David", 15, "Good afternoon David")]
    [InlineData("David", 16, "Good afternoon David")]
    [InlineData("David", 17, "Good afternoon David")]
    [InlineData("David", 18, "Good evening David")]
    [InlineData("David", 19, "Good evening David")]
    [InlineData("David", 20, "Good evening David")] 
    [InlineData("David", 21, "Good evening David")]
    [InlineData("David", 22, "Good evening David")]
    [InlineData("David", 23, "Good evening David")]
   
    public void GreetingShouldReturnExpectedValue(string firstname, int hourOfTheDay, string expected) 
    {
        // Arrange
        DisplayMessages messages = new DisplayMessages();

        // Act
        string actual = messages.Greeting(firstname, hourOfTheDay);

        //Assert
        Assert.Equal(expected, actual);
    }
}