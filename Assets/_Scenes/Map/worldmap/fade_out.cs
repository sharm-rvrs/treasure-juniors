using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade_out : MonoBehaviour
{
    int color_a = 0;
    [SerializeField] private Image Fade_Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (color_a < 254)
        {
            color_a++;
            color_a++;
            Fade_Panel.color = new Color32(0, 0, 0, ((byte)color_a));
        }
        if(color_a == 254)
        {
            Fade_Panel.color = new Color32(0, 0, 0, 255);
        }
        

    }
}
