using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login_BTN : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Login_Panel;
    [SerializeField] private GameObject Parent_Panel;

    [SerializeField] private GameObject Home_Panel;
    private void Start()
    {
        
        
    }

    public void Login_Button()
    {
        //PlayerPrefs.SetString("Parent_Name", "");
        string b = PlayerPrefs.GetString("Parent_Name");

        if(b == "")
        {
            Parent_Panel.SetActive(true);
            Home_Panel.SetActive(false);
        }
        else
        {
            Login_Panel.SetActive(true);
            Home_Panel.SetActive(false);
        }

       
    }
}
