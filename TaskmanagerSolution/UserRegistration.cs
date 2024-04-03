namespace TaskmanagerSolution;

public class UserRegistration
{
    public List<User> Users = new List<User>();




    public string AddUser(string UserName, string Email, string Pasword)
    {
        if(Email == null || Pasword == null || UserName == null) {  throw new ArgumentNullException(); }

        if (Users.Exists(U=>U.Name==UserName)) { throw new ArgumentException("User allready exists "); }//throws argument if user exixsts 

        string specialletters = "!@#$%^&*()-_=+";

        if (Pasword == null || Pasword.Length < 8 || !Pasword.Any(c => specialletters.Contains(c))) { throw new ArgumentException("bad password"); }//throws argument id the pasword is wrong and whst it contains  

        if(UserName.Length < 5 || UserName.Length > 20 || !UserName.All(char.IsLetterOrDigit)) { throw new ArgumentException("bad username"); }//what the name should contain and if the username is wrong 


       
        if (!Emailstructure(Email)){throw new ArgumentException("Invalid email format");}//givs argument if email is is wrong and input of email strukture 


        Users.Add(new User(UserName, Email, Pasword));

        return "sucses";
    }
    private bool Emailstructure(string email)
    {
        // the email strukture 
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";
        return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
    }
}
