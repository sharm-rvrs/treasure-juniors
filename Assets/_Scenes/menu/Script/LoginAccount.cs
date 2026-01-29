using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginAccount : MonoBehaviour
{

    string name1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void account1()
    {
        PlayerPrefs.SetInt("account_is", 1);
    }

    public void account2()
    {
        PlayerPrefs.SetInt("account_is", 2);
    }

    public void account3()
    {
        PlayerPrefs.SetInt("account_is", 3);
    }

    public void account4()
    {
        PlayerPrefs.SetInt("account_is", 4);
    }
}
