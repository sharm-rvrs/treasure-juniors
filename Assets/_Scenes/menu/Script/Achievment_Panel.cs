using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievment_Panel : MonoBehaviour
{
    [SerializeField] private GameObject Achievement;
    [SerializeField] private GameObject Mainmenu_Panel;

    // Start is called before the first frame update
    public void Panel_Achievement_Open()
    {
        Achievement.SetActive(true);
        Mainmenu_Panel.SetActive(false);
    }

    public void Panel_Achievement_Close()
    {
        Achievement.SetActive(false);
        Mainmenu_Panel.SetActive(true);
    }
}
