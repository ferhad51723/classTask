class User:Human
{
    public string username;
    public string email;
    private bool isAdmin = false;

    public bool isLogged = false;
    private string password;
    private string Password
    {
        get { return password; }
        set
        {
            if (value.Length < 5) {
                Console.WriteLine("Password simvol sayi 5 den cox olmalidir! (Qeyd: Bu, yalnız ilk təyin olunmada görünəcək)"); 
            }
            password = value;
        }
    }
    public string bio;
    public string ChangePassword(string currentPassword, string newPassword)
    {
        if (currentPassword == newPassword)
        {
            return "Old and new password are same";
        }

        if (currentPassword == this.password)
        {
            this.Password = newPassword;
            return "Password changed successfully";
        }

        return "Current password is incorrect";
    }

    public string ChangeEmail()
    {
        return "1";
    }

    public bool VerifyPassword(string currentPassword)
    {
        return this.password == currentPassword;
    }

    public User(string name,string surname,int age,string gender,string nationality,string username, string email, string password, string bio):base(name,surname,age,gender,nationality)
    {
        this.username = username;
        this.email = email;
        this.Password = password;
        this.bio = bio;
    }
}