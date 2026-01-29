using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
   
    
    int color_a = 255;
    [SerializeField] private Image Fade_Panel_Image;
    [SerializeField] private GameObject Fade_Panel;
    private void Update()
    {
        if (color_a > 0)
        {
            color_a--;
            Fade_Panel_Image.color = new Color32(0, 0, 0, ((byte)color_a));
        }
    }
    void Start()
    {
        int User_ID = PlayerPrefs.GetInt("account_is");

        int a = PlayerPrefs.GetInt(User_ID + "TUTworldmap");

        if (a == 0)
        {
            PlayerPrefs.SetInt(User_ID + "TUTworldmap", 1);

            Fade_Panel.SetActive(true);



        }
        Invoke("close_fade", 3);
    }

 

    void close_fade()
    {
        Fade_Panel.SetActive(false);
    }
}
