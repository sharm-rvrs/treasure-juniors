using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement_Unlock : MonoBehaviour
{
    [SerializeField] private string Achievement_Name_1;
    [SerializeField] private string Achievement_Name_2;
    [SerializeField] private string Achievement_Name_3;
    [SerializeField] private string Achievement_Name_4;
    [SerializeField] private string Achievement_Name_5;

    [SerializeField] private string Achievement_Science_Name_1;
    [SerializeField] private string Achievement_Science_Name_2;
    [SerializeField] private string Achievement_Science_Name_3;

    [SerializeField] private Image Achievement_image_math_1;
    [SerializeField] private Image Achievement_image_math_2;
    [SerializeField] private Image Achievement_image_math_3;
    [SerializeField] private Image Achievement_image_math_4;
    [SerializeField] private Image Achievement_image_math_5;

    [SerializeField] private Image Achievement_image_Science_1;
    [SerializeField] private Image Achievement_image_Science_2;
    [SerializeField] private Image Achievement_image_Science_3;


    int User_ID;

    int achievement_math_1;
    int achievement_math_2;
    int achievement_math_3;
    int achievement_math_4;
    int achievement_math_5;

    int achievement_science_1;
    int achievement_science_2;
    int achievement_science_3;

    void Start()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        achievement_math_1 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_1);
        achievement_math_2 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_2);
        achievement_math_3 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_3);
        achievement_math_4 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_4);
        achievement_math_5 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_5);

        achievement_science_1 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_1);
        achievement_science_2 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_2);
        achievement_science_3 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_3);
    }

    // Update is called once per frame
    void Update()
    {

        User_ID = PlayerPrefs.GetInt("account_is");
        achievement_math_1 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_1);
        achievement_math_2 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_2);
        achievement_math_3 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_3);
        achievement_math_4 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_4);
        achievement_math_5 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Name_5);

        achievement_science_1 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_1);
        achievement_science_2 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_2);
        achievement_science_3 = PlayerPrefs.GetInt(User_ID + "_" + Achievement_Science_Name_3);

        if (achievement_math_1 == 1)
        {
            Achievement_image_math_1.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_math_2 == 1)
        {
            Achievement_image_math_2.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_math_3 == 1)
        {
            Achievement_image_math_3.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_math_4 == 1)
        {
            Achievement_image_math_4.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_math_5 == 1)
        {
            Achievement_image_math_5.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_science_1 == 1)
        {
            Achievement_image_Science_1.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_science_2 == 1)
        {
            Achievement_image_Science_2.color = new Color32(255, 255, 255, 255);
        }

        if (achievement_science_3 == 1)
        {
            Achievement_image_Science_3.color = new Color32(255, 255, 255, 255);
        }
    }


    public void achievement_return_orig()
    {
        Achievement_image_math_1.color = new Color32(0, 0, 0, 255);
        Achievement_image_math_2.color = new Color32(0, 0, 0, 255);
        Achievement_image_math_3.color = new Color32(0, 0, 0, 255);
        Achievement_image_math_4.color = new Color32(0, 0, 0, 255);
        Achievement_image_math_5.color = new Color32(0, 0, 0, 255);

        Achievement_image_Science_1.color = new Color32(0, 0, 0, 255);
        Achievement_image_Science_2.color = new Color32(0, 0, 0, 255);
        Achievement_image_Science_3.color = new Color32(0, 0, 0, 255);
    }
}
