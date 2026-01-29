using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] private string Subject_Topic_Stage;
    [SerializeField] private string Map_Number;


   

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

    int total_score;
    private void Start()
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

        total_score = Best_Score_1 + Best_Score_2 + Best_Score_3 + Best_Score_4 + Best_Score_5;

        string user_id = User_ID.ToString();
        
        PlayerPrefs.SetInt(user_id + "_Total_Coins" + Map_Number,total_score);

        
    }
   
}
