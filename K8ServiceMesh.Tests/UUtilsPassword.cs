namespace K8ServiceMesh.Tests;

using K8ServiceMesh.Utils.PasswordSecurity;


public class UUtilsPassword
{

    private Password _password = new Password();

    public UUtilsPassword(){
        
    }

    [Fact]
    public void PasswordRight()
    {
        var password = "z2*6Uyb;si:$";
        Assert.True(_password.IsValidPassword(password));
    }


    [Fact]
    public void PasswordLengthIncorrect()
    {
        var password = "z2*6Uyb;si:";
        Assert.False(_password.IsValidPassword(password));
    }

    [Fact]
    public void PasswordWithoutUpperCase()
    {
        var password = "z2*6uyb;si:$";
        Assert.False(_password.IsValidPassword(password));
    }

    [Fact]
    public void PasswordWithoutLowerCase()
    {
        var password = "Z2*6UYB;SI:$";
        Assert.False(_password.IsValidPassword(password));
    }

    [Fact]
    public void PasswordWithoutDigits()
    {
        var password = "z&*sUyb;si:$";
        Assert.False(_password.IsValidPassword(password));
    }    

    [Fact]
    public void PasswordWithoutSpecialCharacters()
    {
        var password = "z2i6UybksidE";
        Assert.False(_password.IsValidPassword(password));
    }
}