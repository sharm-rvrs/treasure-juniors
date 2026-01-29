using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    [SerializeField] private GameObject Login_Panel;
    [SerializeField] private GameObject Mainmenu_Panel;

    // Start is called before the first frame update


    private void Start()
    {
        
        
    }
    public void Logout_Account()
    {
        Login_Panel.SetActive(true);
        Mainmenu_Panel.SetActive(false);
    }

   
}
