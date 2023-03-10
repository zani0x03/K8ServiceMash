namespace K8ServiceMesh.Tests;

using K8ServiceMesh.Utils.PasswordSecurity;


public class UUtilsPassword
{

    private Password _password = new Password();

    public UUtilsPassword(){
        
    }

    [Fact]
    public void PasswordCorreto()
    {
        var password = "z2*6Uyb;si:$";
        Assert.True(_password.IsPasswordValid(password));
    }


    [Fact]
    public void PasswordIncorretoTamanho()
    {
        var password = "z2*6Uyb;si:";
        Assert.False(_password.IsPasswordValid(password));
    }

    [Fact]
    public void PasswordSemMaiusculo()
    {
        var password = "z2*6uyb;si:$";
        Assert.False(_password.IsPasswordValid(password));
    }

    [Fact]
    public void PasswordSemMinusculo()
    {
        var password = "Z2*6UYB;SI:$";
        Assert.False(_password.IsPasswordValid(password));
    }

    [Fact]
    public void PasswordSemCaracterEspecial()
    {
        var password = "z2i6UybksidE";
        Assert.False(_password.IsPasswordValid(password));
    }
}