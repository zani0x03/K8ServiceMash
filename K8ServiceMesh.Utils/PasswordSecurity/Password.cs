namespace K8ServiceMesh.Utils.PasswordSecurity;

using System.Text.RegularExpressions;


public class Password : IPassword
{

    public Password(){

    }

    public bool IsValidPassword(string password)
    {
        bool isPasswordValid = true;
        
        // Check password length
        if (password.Length < 12)
        {
            isPasswordValid = false;
        }
        
        // Check for uppercase letters
        if (!Regex.IsMatch(password, "[A-Z]"))
        {
            isPasswordValid = false;
        }
        
        // Check for lowercase letters
        if (!Regex.IsMatch(password, "[a-z]"))
        {
            isPasswordValid = false;
        }
        
        // Check for digits
        if (!Regex.IsMatch(password, "[0-9]"))
        {
            isPasswordValid = false;
        }
        
        // Check for special characters
        if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
        {
            isPasswordValid = false;
        }
        
        return isPasswordValid;
    }

}
