using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TUT_Mainmenu : MonoBehaviour
{
    int a;

    [SerializeField] private GameObject TUT_mainmenu;

    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;
    [SerializeField] private GameObject box4;

    [SerializeField] private GameObject textbox1;
    [SerializeField] private GameObject textbox2;
    [SerializeField] private GameObject textbox3;
    [SerializeField] private GameObject textbox4;


    [SerializeField] private GameObject arrow1;
    [SerializeField] private GameObject arrow2;
    [SerializeField] private GameObject arrow3;
    [SerializeField] private GameObject arrow4;

    [SerializeField] private GameObject btn1;
    [SerializeField] private GameObject btn2;
    [SerializeField] private GameObject btn3;
    [SerializeField] private GameObject btn4;

    [SerializeField] private GameObject achievement_pointer_panel;

    [SerializeField] private GameObject newgame_pointer_panel;

    [SerializeField] private GameObject TUTmain_menu;

    private void Start()
    {
        int a = PlayerPrefs.GetInt("TUT_Mainmenu");

        

        if(a == 0)
        {
            TUT_mainmenu.SetActive(true);
            PlayerPrefs.SetInt("TUT_Mainmenu", 1);
        }
    }


    public void phase1()
    {
        btn1.SetActive(false);

        box1.SetActive(false);
        box2.SetActive(true);

        textbox1.SetActive(false);
        textbox2.SetActive(true);

        arrow1.SetActive(false);
        arrow2.SetActive(true);
    }

    public void phase2()
    {
        btn2.SetActive(false);

        box2.SetActive(false);
        box3.SetActive(true);

        textbox2.SetActive(false);
        textbox3.SetActive(true);

        arrow2.SetActive(false);
        arrow3.SetActive(true);
    }

    public void phase3()
    {
        btn3.SetActive(false);

        box3.SetActive(false);
        box4.SetActive(true);

        textbox3.SetActive(false);
        textbox4.SetActive(true);

        arrow3.SetActive(false);
        arrow4.SetActive(true);
    }

    public void phase4()
    {
        btn4.SetActive(false);

        
        box4.SetActive(false);

        textbox4.SetActive(false);
       

        arrow4.SetActive(false);
       

        achievement_pointer_panel.SetActive(true);
    }

    public void extra_phase()
    {
        achievement_pointer_panel.SetActive(false);
        newgame_pointer_panel.SetActive(true);
        TUTmain_menu.GetComponent<Image>().color = new Color(0, 0, 0,0);

    }
    public void Last_phase()
    {
        
        TUT_mainmenu.SetActive(false);
        
    }
}
