using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScorePanel : MonoBehaviour
{
    [SerializeField] private GameObject ScorePanels;
    [SerializeField] private GameObject Pause_Panel;
    [SerializeField] private GameObject Confirm_Panel;
    [SerializeField] private GameObject Tutorial_Panel;


    [SerializeField] private string Subject_Topic_Stage_Level;
    
    // Start is called before the first frame update
    float timer = 0;

     public TextMeshProUGUI Score_Result;
     public TextMeshProUGUI Time_Result;
    public TextMeshProUGUI Time_Show;
    public TextMeshProUGUI Best_Score;
    int time_hours;
    int time_minutes;
    int time_seconds;
    


    private void Start()
    {
        //PlayerPrefs.SetInt("Math_Logic_Stage1_Level2_Score_Result_Try_1",0);
        //PlayerPrefs.SetInt("Math_Logic_Stage1_Level2_Score_Result_Try_2", 0);
        //PlayerPrefs.SetInt("Math_Logic_Stage1_Level2_Score_Result_Try_3", 0);
        //PlayerPrefs.SetInt("Math_Logic_Stage1_Level2_Score_Result_Try_4", 0);
        
    }
    private void Update()
    {

    if(Pause_Panel.activeInHierarchy == false && Confirm_Panel.activeInHierarchy == false && ScorePanels.activeInHierarchy == false && Tutorial_Panel.activeInHierarchy == false)
        {
            timer += Time.deltaTime;
            if (timer >= 60)
            {
                time_minutes += 1;
                timer = 0;
            }
            if (time_minutes >= 60)
            {
                time_hours += 1;
                time_minutes = 0;
                timer = 0;
            }
            time_seconds = (int)timer;

            if (time_minutes <= 0 && time_seconds <= 9)
            {
                Time_Show.text = time_seconds.ToString() + " s";

            }

            if (time_hours >= 0 && time_minutes >= 9 && time_seconds <= 9)
            {
                Time_Result.text = time_hours.ToString() + ":" + time_minutes.ToString() + ":0" + time_seconds.ToString() + " hr";


            }


            if (time_hours >= 0 && time_minutes <= 9 && time_seconds <= 9)
            {
                Time_Result.text = time_hours.ToString() + ":0" + time_minutes.ToString() + ":0" + time_seconds.ToString() + " hr";



            }



            if (time_minutes >= 1 && time_seconds >= 9)
            {
                Time_Show.text = time_minutes.ToString() + ":" + time_seconds.ToString() + " m";

            }

            if (time_minutes >= 1 && time_seconds >= 9)
            {
                Time_Show.text = time_minutes.ToString() + ":" + time_seconds.ToString() + " m";

            }

            if (time_minutes >= 1 && time_seconds <= 9)
            {
                Time_Show.text = time_minutes.ToString() + ":0" + time_seconds.ToString() + " m";

            }

            if (time_minutes <= 0 && time_seconds >= 9)
            {
                Time_Show.text = time_seconds.ToString() + " s";

            }
        }

       

        

       

    }

   //------------------------------------------

    public void SubmitBTN()
    {
        Confirm_Panel.SetActive(false);
        int Correct = PlayerPrefs.GetInt("correct");
        ScorePanels.SetActive(true);
        Score_Result.text = Correct.ToString();


        if (time_hours >= 0 && time_minutes >= 9 && time_seconds <= 9)
        {
            Time_Result.text = time_hours.ToString() + ":" + time_minutes.ToString() + ":0" + time_seconds.ToString() + " hr";
            
            
        }


        if (time_hours >= 0 && time_minutes <= 9 && time_seconds <= 9)
        {
            Time_Result.text = time_hours.ToString()+ ":0" + time_minutes.ToString() + ":0" + time_seconds.ToString() + " hr";
            

            
        }

        

        if (time_minutes >= 1 && time_seconds >= 9)
        {
            Time_Result.text = time_minutes.ToString() + ":" + time_seconds.ToString() + " m";
            
        }

        if (time_minutes >= 1 && time_seconds >= 9)
        {
            Time_Result.text = time_minutes.ToString() + ":" + time_seconds.ToString() + " m";
            
        }

        if (time_minutes >= 1 && time_seconds <= 9)
        {
            Time_Result.text = time_minutes.ToString() + ":0" + time_seconds.ToString() + " m";
            
        }

        if (time_minutes <= 0 && time_seconds >= 9)
        {
            Time_Result.text = time_seconds.ToString() + " s";
            
        }

        if (time_minutes <= 0 && time_seconds <= 9)
        {
            Time_Result.text = time_seconds.ToString() + " s";
           
        }



        int User_ID = PlayerPrefs.GetInt("account_is");

        
        for(int i = 1; i >= 0; i++)
        {

            

            string Score_Result = User_ID+"_"+Subject_Topic_Stage_Level + "_Score_Result_" + i;
            string Score_Time = User_ID + "_" + Subject_Topic_Stage_Level + "_Score_Time_" + i;
            string Score_Date = User_ID + "_" + Subject_Topic_Stage_Level + "_Date_" + i;
            string Score_BestScore = User_ID + "_" + Subject_Topic_Stage_Level + "_Score_BestScore";




            int Result = PlayerPrefs.GetInt(Score_Result);
            
            string Time_Result = Time_Show.GetParsedText();

            if (Result == 0)
            {
                string TimeShow = Time_Show.ToString();
                PlayerPrefs.SetInt(Score_Result, Correct);
                PlayerPrefs.SetString(Score_Time, Time_Result);
                PlayerPrefs.SetString(Score_Date, System.DateTime.Now.ToString());

                int BestScores = PlayerPrefs.GetInt(Score_BestScore);

                if(Correct < BestScores)
                {
                    Best_Score.text = BestScores.ToString();
                    
                }
                else
                {
                    PlayerPrefs.SetInt(Score_BestScore, Correct);
                    Best_Score.text = Correct.ToString();

                }

                //int Best_Scores = PlayerPrefs.GetInt(Score_BestScore);

                //if(Correct > Best_Scores)
                //{
                //    PlayerPrefs.SetInt(Score_BestScore, Correct);
                //    Best_Score.text = Correct.ToString();

                //}
                //else
                //{
                //    Best_Score.text = Best_Scores.ToString();
                //}
                break;
            }

            

        }











    }
}
