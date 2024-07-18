using System;

public class check_login
{
	public check_login()
	{
	}

    public bool ValidateLogin(string username, string password)
    {   
        // dummy function to login!!!
        // Check if the username is "admin" and the password is "admin123"
        if (username == "admin" && password == "admin123")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
