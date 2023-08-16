using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Proyecto26;

[Serializable]
public class User
{
    public string firstName { get; private set; }
    public string lastName { get; private set; }
    public string username { get; private set; }
    public string password { get; private set; }
    public string email { get; private set; }
    public string birthday { get; private set; }

    public User()
    {
        firstName = UserValues.firstNameText;
        lastName = UserValues.lastNameText;
        username = UserValues.usernameText;
        password = UserValues.passwordText;
        email = UserValues.emailText;
        birthday = UserValues.birthdayText;
    }
}
