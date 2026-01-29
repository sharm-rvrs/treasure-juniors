using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class Account : MonoBehaviour
{

   

    public GameObject deletebutton1;
    public GameObject deletebutton2;
    public GameObject deletebutton3;
    public GameObject deletebutton4;

    public TextMeshProUGUI username1;
    public TextMeshProUGUI username2;
    public TextMeshProUGUI username3;
    public TextMeshProUGUI username4;

    public TMP_InputField PlayerS_Username;
    public TMP_InputField parent_firstname;
    public TMP_InputField parent_lastname;

    public GameObject Monitoring_Canvas;
    public GameObject Player_Canvas;
    public GameObject Parent_Canvas;
    public GameObject Home_Canvas;
    public GameObject Login_Canvas;
    public GameObject MainMenu_Canvas;

    public Button playernextBTN;
    public Button SubmitBTN;

    public GameObject Are_You_Sure;
    public TextMeshProUGUI Username;

    //public GameObject cameralook;
    //public GameObject Cam1;
    //public NavMeshAgent Camera;

    public GameObject CharMale;
    public GameObject CharFemale;

    public GameObject CharHolder;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerS_Username.text == "")
        {
            playernextBTN.interactable = false;
        }
        else
        {
            playernextBTN.interactable = true;
        }

        if(parent_firstname.text == "" && parent_lastname.text == "" || parent_firstname.text != "" && parent_lastname.text == "" || parent_firstname.text == "" && parent_lastname.text != "")
        {
            SubmitBTN.interactable = false;
        }
        else
        {
            SubmitBTN.interactable = true;
        }


    }


    //public void gamestart()
    //{
         
    //    Vector3 camPos1 = Cam1.transform.position;
    //    Vector3 camlookat = cameralook.transform.position;
    //    transform.LookAt(camlookat);
    //    Camera.SetDestination(camPos1);
    //}
    public void create_account()
    {

        Player_Canvas.SetActive(true);
        Login_Canvas.SetActive(false);
        CharHolder.SetActive(true);

        if (username1.text != "" || username2.text != "" || username3.text != "" || username4.text != "")
        {
            
        }
        else
        {

        }



       


    }

    public void Next_Player_Account()
    {

        string a = PlayerS_Username.text;

        PlayerPrefs.SetString("username_holder", a);
        
        //Parent_Canvas.SetActive(true);
        
        if (username1.text == "")
        {
            PlayerPrefs.SetString("account1_username", a);

            if (CharMale.activeInHierarchy)
            {
                PlayerPrefs.SetInt("account1_char", 1);
            }
            else
            {
                PlayerPrefs.SetInt("account1_char", 2);

            }
            
        }
        else if (username2.text == "")
        {
            PlayerPrefs.SetString("account2_username", a);

            if (CharMale.activeInHierarchy)
            {
                PlayerPrefs.SetInt("account2_char", 1);
            }
            else
            {
                PlayerPrefs.SetInt("account2_char", 2);

            }
        }
        else if (username3.text == "")
        {
            PlayerPrefs.SetString("account3_username", a);

            if (CharMale.activeInHierarchy)
            {
                PlayerPrefs.SetInt("account3_char", 1);
            }
            else
            {
                PlayerPrefs.SetInt("account3_char", 2);

            }
        }
        else if (username4.text == "")
        {
            PlayerPrefs.SetString("account4_username", a);

            if (CharMale.activeInHierarchy)
            {
                PlayerPrefs.SetInt("account4_char", 1);
            }
            else
            {
                PlayerPrefs.SetInt("account4_char", 2);

            }
        }
        PlayerS_Username.text = "";
        Player_Canvas.SetActive(false);
        CharHolder.SetActive(false);
        Login_Canvas.SetActive(true);
    }

    public void Parent_Submit()
    {
        PlayerPrefs.SetString("parent_account_holder", parent_firstname.text + " " + parent_lastname.text);
        PlayerPrefs.SetString("Parent_First", parent_firstname.text);
        PlayerPrefs.SetString("Parent_Last", parent_lastname.text);
        string a = PlayerPrefs.GetString("username_holder");
        string b = PlayerPrefs.GetString("parent_account_holder");
        PlayerPrefs.SetString("Parent_Name", b);
        //if (username1.text == "")
        //{
        //    PlayerPrefs.SetString("account1_username", a);
        //    PlayerPrefs.SetString("account1_parentname", b);
        //}
        //else if (username2.text == "")
        //{
        //    PlayerPrefs.SetString("account2_username", a);
        //    PlayerPrefs.SetString("account2_parentname", b);
        //}
        //else if (username3.text == "")
        //{
        //    PlayerPrefs.SetString("account3_username", a);
        //    PlayerPrefs.SetString("account3_parentname", b);
        //}
        //else if (username4.text == "")
        //{
        //    PlayerPrefs.SetString("account4_username", a);
        //    PlayerPrefs.SetString("account4_parentname", b);
        //}
    }

    public void loginsubmit()
    {
     Player_Canvas.SetActive(false);
        CharHolder.SetActive(false);
     Parent_Canvas.SetActive(false);
     Home_Canvas.SetActive(false);
    Login_Canvas.SetActive(true);
    MainMenu_Canvas.SetActive(false);

        PlayerS_Username.text = "";
        parent_firstname.text = "";
        parent_lastname.text = "";

    }
    public void deleteNO()
    {
        Are_You_Sure.SetActive(false);
        deletebutton1.SetActive(false);
        deletebutton2.SetActive(false);
        deletebutton3.SetActive(false);
        deletebutton4.SetActive(false);
    }
    public void DeleteBTN1()
    {
        Are_You_Sure.SetActive(true);
        deletebutton1.SetActive(true);
    }

    public void DeleteBTN2()
    {
        Are_You_Sure.SetActive(true);
        deletebutton2.SetActive(true);
    }

    public void DeleteBTN3()
    {
        Are_You_Sure.SetActive(true);
        deletebutton3.SetActive(true);
    }

    public void DeleteBTN4()
    {
        Are_You_Sure.SetActive(true);
        deletebutton4.SetActive(true);
    }
    public void deleteaccount1()
    {
        PlayerPrefs.SetString("account1_username", "");
        PlayerPrefs.SetString("account1_parentname", "");
        deleteNO();
    }

    public void deleteaccount2()
    {
        PlayerPrefs.SetString("account2_username", "");
        PlayerPrefs.SetString("account2_parentname", "");
        deleteNO();
    } 

    public void deleteaccount3()
    {
        PlayerPrefs.SetString("account3_username", "");
        PlayerPrefs.SetString("account3_parentname", "");
        deleteNO();

    }
    public void deleteaccount4()
    {

        PlayerPrefs.SetString("account4_username", "");
        PlayerPrefs.SetString("account4_parentname", "");
        deleteNO();
    }

    public void User1()
    {
        MainMenu_Canvas.SetActive(true);
        Home_Canvas.SetActive(false);
        Login_Canvas.SetActive(false);
        Username.text = PlayerPrefs.GetString("account1_username").ToString();
        PlayerPrefs.SetInt("account_is", 1);

    }

    public void User2()
    {
        MainMenu_Canvas.SetActive(true);
        Home_Canvas.SetActive(false);
        Login_Canvas.SetActive(false);
        Username.text = PlayerPrefs.GetString("account2_username").ToString();
        PlayerPrefs.SetInt("account_is", 2);
    }

    public void User3()
    {
        MainMenu_Canvas.SetActive(true);
        Home_Canvas.SetActive(false);
        Login_Canvas.SetActive(false);
        Username.text = PlayerPrefs.GetString("account3_username").ToString();
        PlayerPrefs.SetInt("account_is", 3);
    }

    public void User4()
    {
        MainMenu_Canvas.SetActive(true);
        Home_Canvas.SetActive(false);
        Login_Canvas.SetActive(false);
        Username.text = PlayerPrefs.GetString("account4_username").ToString();
        PlayerPrefs.SetInt("account_is", 4);
    }


    public void nextchar()
    {
        if (CharMale.activeInHierarchy)
        {
            CharFemale.SetActive(true);
            CharMale.SetActive(false);
        }
        else
        {
            CharMale.SetActive(true);
            CharFemale.SetActive(false);

        }
    }
    public void Monitoring_Panel_On()
    {
        Monitoring_Canvas.SetActive(true);
    }
    public void Monitoring_Panel_Off()
    {
        Monitoring_Canvas.SetActive(false);
    }
    public void login_panel_On()
    {
        Login_Canvas.SetActive(true);
    }

    public void login_panel_Off()
    {
        Login_Canvas.SetActive(false);
    }
}


 