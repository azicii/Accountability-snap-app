using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserValues : MonoBehaviour
{
     public TMP_InputField firstName;
     public TMP_InputField lastName;
     public TMP_InputField username;
     public TMP_InputField password;
     public TMP_InputField email;
     public TMP_InputField birthday;

     public static string firstNameText;
     public static string lastNameText;
     public static string usernameText;
     public static string passwordText;
     public static string emailText;
     public static string birthdayText;

    public void OnSubmit()
    {
        firstNameText = firstName.text;
        lastNameText = lastName.text;
        usernameText = username.text;
        passwordText = password.text;
        emailText = email.text;
        birthdayText = birthday.text;

        PostToDataBase();
    }

    private void PostToDataBase()
    {
        RestClient.Post("https://picability-81822-default-rtdb.firebaseio.com/.json", );
    }
}
