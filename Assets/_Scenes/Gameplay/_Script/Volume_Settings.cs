using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume_Settings : MonoBehaviour
{
   
    public Slider VolumeBGSlider;
    public Slider VolumeSESlider;


    // Start is called before the first frame update
    void Start()
    {
        float a = PlayerPrefs.GetFloat("Global_BG_Volume");
        VolumeBGSlider.value = PlayerPrefs.GetFloat("Global_BG_Volume");

        float b = PlayerPrefs.GetFloat("Global_SE_Volume");
        VolumeSESlider.value = PlayerPrefs.GetFloat("Global_SE_Volume");

    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetFloat("Global_BG_Volume", VolumeBGSlider.value);
        PlayerPrefs.SetFloat("Global_SE_Volume", VolumeSESlider.value);


    }

    public void SettingDone()
    {
        PlayerPrefs.SetFloat("Global_BG_Volume", VolumeBGSlider.value);
        PlayerPrefs.SetFloat("Global_SE_Volume", VolumeSESlider.value);
    }
}
