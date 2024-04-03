namespace TaskmanagerSolution.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Registrationvalidation()//check if the regastration is valid 
    {
        //arange 
        var userRegistration = new UserRegistration();
        string name = "testname";
        string email = "emailtest@mail.com";
        string pasword = "paswordtest@";

        //act
       string result = userRegistration.AddUser(name, email, pasword);
        //assert
        Assert.IsTrue(result.Contains("sucses"));

    }

    [TestMethod]
    public void UniceUsernamevaidation()//chek if the user allredy exists
    {
        //arange 
        var userRegistration = new UserRegistration();
        string name = "testname";
        string email = "emailtest@mail.com";
        string pasword = "paswordtest@";



        // Act and Assert
        string result = userRegistration.AddUser(name, email, pasword);

        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            string result = userRegistration.AddUser(name, email, pasword);
        });

        // Assert
        Assert.AreEqual("User allready exists ", exception.Message);



    }

    [TestMethod]
    public void UserInputNameValidation()//check if the pasword is wrong 
    {
        //arange 
        var userRegistration = new UserRegistration();
        string name = "lo";
        string email = "emailtest@mail.com";
        string pasword = "paswordtest@";

        // Act and Assert

        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            string result = userRegistration.AddUser(name, email, pasword);
        });

        // Assert
        Assert.AreEqual("bad username", exception.Message);



    }
    [TestMethod]
    public void UserInputEmailValidation()//check if the email is wrong
    {
        //arange 
        var userRegistration = new UserRegistration();
        string name = "testname";
        string email = "emailtest";
        string pasword = "paswordtest@";

        // Act and Assert

        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            string result = userRegistration.AddUser(name, email, pasword);
        });

        // Assert
        Assert.AreEqual("Invalid email format", exception.Message);



    }
    [TestMethod]
    public void UserInputPaswordValidation()//check if the pasword is wrong 
    {
        //arange 
        var userRegistration = new UserRegistration();
        string name = "testname";
        string email = "emailtest@mail.com";
        string pasword = "paswordtest";

        // Act and Assert

        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            string result = userRegistration.AddUser(name, email, pasword);
        });

        // Assert
        Assert.AreEqual("bad password", exception.Message);



    }



}