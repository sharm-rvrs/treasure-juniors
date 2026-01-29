using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement_Condition : MonoBehaviour
{
    [SerializeField] private string Subject_Topic_Stage;

    [SerializeField] private int Level_1_MAx_Score;
    [SerializeField] private int Level_2_MAx_Score;
    [SerializeField] private int Level_3_MAx_Score;
    [SerializeField] private int Level_4_MAx_Score;
    [SerializeField] private int Level_5_MAx_Score;

    [Header("Target score to next level")]
    [SerializeField] private int TargetScore1;
    [SerializeField] private int TargetScore2;
    [SerializeField] private int TargetScore3;
    [SerializeField] private int TargetScore4;
    [SerializeField] private int TargetScore5;

    [Header("Chest ")]
    [SerializeField] private GameObject Chest1_nextlevel;
    [SerializeField] private GameObject Chest2;
    [SerializeField] private GameObject Chest3;
    [SerializeField] private GameObject Chest4;
    [SerializeField] private GameObject Chest5;

    [Header("Chest Animator")]
    [SerializeField] private Animator Chest1_anim;
    [SerializeField] private Animator Chest2_anim;
    [SerializeField] private Animator Chest3_anim;
    [SerializeField] private Animator Chest4_anim;
    [SerializeField] private Animator Chest5_anim;

    [Header("Achievment")]
    [SerializeField] private GameObject Achievement_Medal_Panel;
    [SerializeField] private string Achievement_Medal_Name;

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

        if (Best_Score_1 >= TargetScore1)
        {
            Chest2.SetActive(true);
            //Chest1_anim.Play("open");
        }

        if (Best_Score_2 >= TargetScore2)
        {
            Chest3.SetActive(true);
            //Chest2_anim.Play("open");
        }

        if (Best_Score_3 >= TargetScore3)
        {
            Chest4.SetActive(true);
            //Chest3_anim.Play("open");
        }

        if (Best_Score_4 >= TargetScore4)
        {
            Chest5.SetActive(true);
            //Chest4_anim.Play("open");
        }

        if (Best_Score_5 >= TargetScore5)
        {
            Chest1_nextlevel.SetActive(true);
            //Chest5_anim.Play("open");
        }


        if (Best_Score_1 == Level_1_MAx_Score && Best_Score_2 == Level_2_MAx_Score && Best_Score_3 == Level_3_MAx_Score && Best_Score_4 == Level_4_MAx_Score && Best_Score_5 == Level_5_MAx_Score)
        {

            string b = User_ID + "_" + Achievement_Medal_Name;
            int a = PlayerPrefs.GetInt(b);
            if(a == 0)
            {
                Achievement_Medal_Panel.SetActive(true);
                PlayerPrefs.SetInt(b, 1);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Best_Score_1 >= TargetScore1)
        {
            Chest2.SetActive(true);
            Chest1_anim.Play("open");
        }

        if (Best_Score_2 >= TargetScore2)
        {
            Chest3.SetActive(true);
            Chest2_anim.Play("open");
        }

        if (Best_Score_3 >= TargetScore3)
        {
            Chest4.SetActive(true);
            Chest3_anim.Play("open");
        }

        if (Best_Score_4 >= TargetScore4)
        {
            Chest5.SetActive(true);
            Chest4_anim.Play("open");
        }

        if (Best_Score_5 >= TargetScore5)
        {
            Chest1_nextlevel.SetActive(true);
            Chest5_anim.Play("open");
        }
    }
}
