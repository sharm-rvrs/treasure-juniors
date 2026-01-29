using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PC_Math_Panel_Topic : MonoBehaviour
{
    [SerializeField] private GameObject Scroll_View_Panel;
    [SerializeField] private GameObject Scroll_View_Panel_Science;

    [SerializeField] private TextMeshProUGUI Result_history;
    [SerializeField] private TextMeshProUGUI Result_history_Science;

    [SerializeField] private RectTransform Size;
    [SerializeField] private RectTransform Size_Science;

    
   

    [SerializeField] private float Size_Per_try = 150;
    // Start is called before the first frame update

   

    int Level;
    string Topic;
    void Start()
    {
        Result_history.text = "";
    }

    // Update is called once per frame
    public void View_History()
    {
        Result_history.text = "";
        string a = "";
        string b = "";
        float size = 0;
        int User_ID = PlayerPrefs.GetInt("account_is");

        for (int i = 1; i >= 0; i++)
        {



            string Score_Result = User_ID + "_"+ Topic + "Level"+ Level + "_Score_Result_" + i;
            string Score_Time = User_ID + "_" + Topic + "Level" + Level + "_Score_Time_" + i;
            string Score_Date = User_ID + "_" + Topic + "Level" + Level + "_Date_" + i;
            string Score_BestScore = User_ID + "_" + Topic + "Level" + Level + "_Score_BestScore";

            int Result = PlayerPrefs.GetInt(Score_Result);
            string Timer = PlayerPrefs.GetString(Score_Time);
            string Date = PlayerPrefs.GetString(Score_Date);

            if (Timer != "")
            {

                b =
                "Game: " + i + "\n" +
                "Score: " + Result + " Time: " + Timer + " Date: " + Date + "\n" +
                "" + "\n";
                a = b + a;
                size += Size_Per_try;
                Size.sizeDelta = new Vector2(Size.sizeDelta.x, size);
                Result_history.text = a;

                


            }
            else
            {
                
                break;
            }


        }
    }

    public void View_History_science()
    {
        Result_history_Science.text = "";
        string a = "";
        string b = "";
        float size = 0;
        int User_ID = PlayerPrefs.GetInt("account_is");

        for (int i = 1; i >= 0; i++)
        {



            string Score_Result = User_ID + "_" + Topic + "Level" + Level + "_Score_Result_" + i;
            string Score_Time = User_ID + "_" + Topic + "Level" + Level + "_Score_Time_" + i;
            string Score_Date = User_ID + "_" + Topic + "Level" + Level + "_Date_" + i;
            string Score_BestScore = User_ID + "_" + Topic + "Level" + Level + "_Score_BestScore";

            int Result = PlayerPrefs.GetInt(Score_Result);
            string Timer = PlayerPrefs.GetString(Score_Time);
            string Date = PlayerPrefs.GetString(Score_Date);

            if (Timer != "")
            {

                b =
               "Game: " + i + "\n" +
               "Score: " + Result + " Time: " + Timer + " Date: " + Date + "\n" +
               "" + "\n";
                a = a + b;
                size += Size_Per_try;
                Size_Science.sizeDelta = new Vector2(Size_Science.sizeDelta.x, size);
                Result_history_Science.text = a;



            }
            else
            {

                break;
            }


        }
    }

    public void Level_1()
    {
        Level = 1;
    }

    public void Level_2()
    {
        Level = 2;
    }

    public void Level_3()
    {
        Level = 3;
    }

    public void Level_4()
    {
        Level = 4;
    }

    public void Level_5()
    {
        Level = 5;
    }

    public void Logic_BTN()
    {
        Topic = "Math_Logic_Stage1_";
        Result_history.text = "";
        Scroll_View_Panel.SetActive(false);
        Scroll_View_Panel.SetActive(true);

    }

    public void Number_Sense_BTN()
    {
        Topic = "Math_Number_Sense_Stage2_";
        Result_history.text = "";
        Scroll_View_Panel.SetActive(false);
        Scroll_View_Panel.SetActive(true);
    }

    public void Measurement_BTN()
    {
        Topic = "Math_Measurement_Stage3_";
        Result_history.text = "";
        Scroll_View_Panel.SetActive(false);
        Scroll_View_Panel.SetActive(true);
    }

    public void Geometry_BTN()
    {
        Topic = "Math_Geometry_Stage4_";
        Result_history.text = "";
        Scroll_View_Panel.SetActive(false);
        Scroll_View_Panel.SetActive(true);
    }

    public void Stat_Prob_BTN()
    {
        Topic = "Math_Stat_Prob_Stage5_";
        Result_history.text = "";
        Scroll_View_Panel.SetActive(false);
        Scroll_View_Panel.SetActive(true);
    }


    public void Life_Science_BTN()
    {
        Topic = "Science_Life_Science_Stage1_";
        Result_history_Science.text = "";
        Scroll_View_Panel_Science.SetActive(false);
        Scroll_View_Panel_Science.SetActive(true);

    }

    public void Physical_Science_BTN()
    {
        Topic = "Science_Physical_Science_Stage2_";
        Result_history_Science.text = "";
        Scroll_View_Panel_Science.SetActive(false);
        Scroll_View_Panel_Science.SetActive(true);

    }

    public void Earth_Science_BTN()
    {
        Topic = "Science_Earth_Science_Stage3_";
        Result_history_Science.text = "";
        Scroll_View_Panel_Science.SetActive(false);
        Scroll_View_Panel_Science.SetActive(true);

    }


    public void close_scroll_math_panel()
    {
        Scroll_View_Panel.SetActive(false);
    }

    public void close_scroll_science_panel()
    {
        Scroll_View_Panel_Science.SetActive(false);
    }
}
