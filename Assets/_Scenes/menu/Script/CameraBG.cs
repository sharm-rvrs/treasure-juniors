using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class CameraBG : MonoBehaviour
{
    public GameObject cameralook;
    public GameObject lookCharselect;
    public GameObject lookCharLogin;


    public GameObject Cam1;
    public GameObject Charselect;
    public GameObject Char_Login;
    public GameObject StartCampos;

    public NavMeshAgent CameraAgent;
    public GameObject Camera;

    [SerializeField] private GameObject Mainmenu_panel;
    [SerializeField] private GameObject players_Menu_panel;

    [SerializeField] private TextMeshProUGUI Username;
    Vector3 camlookat;
    void Start()
    {
        camlookat = cameralook.transform.position;

        int return_from_map = PlayerPrefs.GetInt("return_from_map");

        if (return_from_map == 1)
        {
            Mainmenu_panel.SetActive(false);
            players_Menu_panel.SetActive(true);
            playerLogin();
            PlayerPrefs.SetInt("account_is", PlayerPrefs.GetInt("Player_is"));
            

            int a = PlayerPrefs.GetInt("Player_is");
            string b = "account" + a + "_username";
            Username.text = PlayerPrefs.GetString(b).ToString();
            PlayerPrefs.SetInt("return_from_map", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        Camera.transform.LookAt(camlookat);
    }

    public void Login()
    {

        CameraAgent.SetDestination(Cam1.transform.position);
        camlookat = cameralook.transform.position;
        
    }

    public void charselect()
    {

        CameraAgent.SetDestination(Charselect.transform.position);
        camlookat = lookCharselect.transform.position;
        
    }

    public void StarCam()
    {

        CameraAgent.SetDestination(StartCampos.transform.position);
        camlookat = cameralook.transform.position;

    }

    public void playerLogin()
    {

        CameraAgent.SetDestination(Char_Login.transform.position);
        camlookat = lookCharLogin.transform.position;

    }
}
