using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first_install : MonoBehaviour
{

    string name;
    public Slider VolumeBGSlider;
    public Slider VolumeSESlider;
    // Start is called before the first frame update
    void Start()
    {
        name = PlayerPrefs.GetString("parent_account_holder");

        if(name == "")
        {
            PlayerPrefs.SetFloat("Global_BG_Volume",100);
            VolumeBGSlider.value = PlayerPrefs.GetFloat("Global_BG_Volume");

            PlayerPrefs.SetFloat("Global_SE_Volume",100);
            VolumeSESlider.value = PlayerPrefs.GetFloat("Global_SE_Volume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
