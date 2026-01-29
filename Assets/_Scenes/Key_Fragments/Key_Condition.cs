using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Condition : MonoBehaviour
{
    [SerializeField] private string Subject_Topic_Stage;

    [SerializeField] private GameObject key_panel;

    [Header("Target score to next level")]
    [SerializeField] private int TargetScore1;
    [SerializeField] private int TargetScore2;
    [SerializeField] private int TargetScore3;
    [SerializeField] private int TargetScore4;
    [SerializeField] private int TargetScore5;


    [Header("Key")]
    [SerializeField] private GameObject Achievement_Key;
    [SerializeField] private GameObject Achievement_Key1;

    [SerializeField] private string Achievement_Key_Name;

    [SerializeField] GameObject shing;

    int User_ID;
    string Identifier_1;
    string Identifier_2;
    string Identifier_3;
    string Identifier_4;
    string Identifier_5;

    int Best_Score_1;
    int Best_Score_2;
    int Best_Score_3;
    int Best_Score_4;
    int Best_Score_5;

    void Start()
    {

        User_ID = PlayerPrefs.GetInt("account_is");

        Identifier_1 = User_ID + "_" + Subject_Topic_Stage + "_" + "Level1_Score_BestScore";
        Best_Score_1 = PlayerPrefs.GetInt(Identifier_1);

        Identifier_2 = User_ID + "_" + Subject_Topic_Stage + "_" + "Level2_Score_BestScore";
        Best_Score_2 = PlayerPrefs.GetInt(Identifier_2);

        Identifier_3 = User_ID + "_" + Subject_Topic_Stage + "_" + "Level3_Score_BestScore";
        Best_Score_3 = PlayerPrefs.GetInt(Identifier_3);

        Identifier_4 = User_ID + "_" + Subject_Topic_Stage + "_" + "Level4_Score_BestScore";
        Best_Score_4 = PlayerPrefs.GetInt(Identifier_4);

        Identifier_5 = User_ID + "_" + Subject_Topic_Stage + "_" + "Level5_Score_BestScore";
        Best_Score_5 = PlayerPrefs.GetInt(Identifier_5);




        if (Best_Score_1 >= 1 && Best_Score_2 >= 1 && Best_Score_3 >= 1 && Best_Score_4 >= 1 && Best_Score_5 >= 1)
        {

            string b = User_ID + "_" + Achievement_Key_Name;
            int a = PlayerPrefs.GetInt(b);
            if (a == 0)
            {
                Achievement_Key.SetActive(true);
                Achievement_Key1.SetActive(true);
                key_panel.SetActive(true);
                PlayerPrefs.SetInt(b, 1);

                shing.SetActive(true);
            }

        }
    }

}
