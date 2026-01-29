using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    [SerializeField] private Button Is_Continue;
    [SerializeField] private GameObject New_Game_Warning;

    private string Subject_Topic_Stage_Level;

    int account;
    int b;

    [Header("Medal Name")]
    [SerializeField] private string Achievement_Name_1;
    [SerializeField] private string Achievement_Name_2;
    [SerializeField] private string Achievement_Name_3;
    [SerializeField] private string Achievement_Name_4;
    [SerializeField] private string Achievement_Name_5;

    [SerializeField] private string Achievement_Science_Name_1;
    [SerializeField] private string Achievement_Science_Name_2;
    [SerializeField] private string Achievement_Science_Name_3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        account = PlayerPrefs.GetInt("account_is");

        if (account == 1)
        {
            b = PlayerPrefs.GetInt("1_Math_Logic_Stage1_Level1_Score_Result_1");
            {
                if (b != 0)
                {
                    Is_Continue.interactable = true;
                }
                else
                {
                    Is_Continue.interactable = false;
                }
            }

        }

        if (account == 2)
        {

            b = PlayerPrefs.GetInt("2_Math_Logic_Stage1_Level1_Score_Result_1");
            {
                if (b != 0)
                {
                    Is_Continue.interactable = true;
                }
                else
                {
                    Is_Continue.interactable = false;
                }
            }
        }

        if (account == 3)
        {

            b = PlayerPrefs.GetInt("3_Math_Logic_Stage1_Level1_Score_Result_1");
            {
                if (b != 0)
                {
                    Is_Continue.interactable = true;
                }
                else
                {
                    Is_Continue.interactable = false;
                }
            }
        }

        if (account == 4)
        {

            b = PlayerPrefs.GetInt("4_Math_Logic_Stage1_Level1_Score_Result_1");
            {
                if (b != 0)
                {
                    Is_Continue.interactable = true;
                }
                else
                {
                    Is_Continue.interactable = false;
                }
            }
        }
    }

    public void New_Game()
    {
        if(Is_Continue.interactable == true)
        {
            New_Game_Warning.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Story");
        }
    }
    public void Warning_Yes()
    {
        Reset_History();
        SceneManager.LoadScene("Story");

    }
    public void Warning_No()
    {
        New_Game_Warning.SetActive(false);
    }



    public void Reset_History()
    {

        int User_ID = PlayerPrefs.GetInt("account_is");

        PlayerPrefs.SetInt(User_ID + "TUTworldmap", 0);
       
        string xax = User_ID + "_Tut";

        PlayerPrefs.SetInt(xax, 0);

        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Name_1, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Name_2, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Name_3, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Name_4, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Name_5, 0);

        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Science_Name_1, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Science_Name_2, 0);
        PlayerPrefs.SetInt(User_ID + "_" + Achievement_Science_Name_3, 0);


        for (int a = 1; a >= 0; a++)
        {

            if (a == 1)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Math_Logic_Stage1_Level";
            }

            if (a == 2)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Math_Number_Sense_Stage2_Level";
            }

            if (a == 3)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Math_Measurement_Stage3_Level";
            }

            if (a == 4)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Math_Geometry_Stage4_Level";
            }

            if (a == 5)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Math_Stat_Prob_Stage5_Level";
            }

            if (a == 6)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Science_Life_Science_Stage1_Level";
            }

            if (a == 7)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Science_Physical_Science_Stage2_Level";
            }
            if (a == 8)
            {
                Subject_Topic_Stage_Level = User_ID + "_" + "Science_Earth_Science_Stage3_Level";
            }
            if (a == 9)
            {
                Debug.Log("all level cleared");
                break;
            }



            for (int b = 1; b <= 6; b++)
            {
                for (int i = 1; i >= 0; i++)
                {

                    string Score_Result = Subject_Topic_Stage_Level + b + "_Score_Result_" + i;
                    string Score_Time = Subject_Topic_Stage_Level + b + "_Score_Time_" + i;
                    string Score_BestScore = Subject_Topic_Stage_Level + b + "_Score_BestScore";
                    string Score_Date = Subject_Topic_Stage_Level + b + "_Date_" + i;

                    string Timer = PlayerPrefs.GetString(Score_Time);

                    if (Timer != "")
                    {
                        PlayerPrefs.SetInt(Score_Result, 0);
                        PlayerPrefs.SetString(Score_Time, "");
                        PlayerPrefs.SetInt(Score_BestScore, 0);
                        PlayerPrefs.SetString(Score_Date, "");

                    }
                    else
                    {

                        break;
                    }
                }


            }





        }
    }

}
