using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePrefDisplayText : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    
    public void Start()
    {
        PlayerPrefs.SetString("user_name", theName);
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("INPUT WORKS");
            StoreName();
        }
    }

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("user_name", theName);
        textDisplay.GetComponent<Text>().text = @"Welcome " + PlayerPrefs.GetString("user_name") + " to the game.";
        PlayerPrefs.Save();
    }
}
