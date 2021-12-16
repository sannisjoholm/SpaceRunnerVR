using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAndScore : MonoBehaviour
{
    public string theName;
    public string theScore;
    public GameObject theNamed;
    public GameObject theScored;


    public void Start()
    {
        theName = PlayerPrefs.GetString("user_name");
        theNamed.GetComponent<Text>().text = theName;
        theScore = PlayerPrefs.GetInt("scores").ToString();
        theScored.GetComponent<Text>().text = theScore;
    }

    

    
}
