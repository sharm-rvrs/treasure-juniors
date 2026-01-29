using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Progress_science : MonoBehaviour
{

    int User_ID;

    int level1;
    int level2;
    int level3;
    int level4;
    int level5;

    [SerializeField] private int island1_Total_Score;
    [SerializeField] private int island2_Total_Score;
    [SerializeField] private int island3_Total_Score;
    [SerializeField] private int island4_Total_Score;
    [SerializeField] private int island5_Total_Score;

    [SerializeField] private TextMeshProUGUI percentage;
    [SerializeField] private TextMeshProUGUI Title;
    [SerializeField] private Image Fillpercent;

    int total;
    void Start()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
    }

    public void Logic_Total_Score()
    {
        User_ID = PlayerPrefs.GetInt("account_is");

        Title.text = "LOGIC";
        
        string Score_BestScore1 = User_ID + "_Math_Logic_Stage1_Level1_Score_BestScore";
        string Score_BestScore2 = User_ID + "_Math_Logic_Stage1_Level2_Score_BestScore";
        string Score_BestScore3 = User_ID + "_Math_Logic_Stage1_Level3_Score_BestScore";
        string Score_BestScore4 = User_ID + "_Math_Logic_Stage1_Level4_Score_BestScore";
        string Score_BestScore5 = User_ID + "_Math_Logic_Stage1_Level5_Score_BestScore";

        level1 = PlayerPrefs.GetInt(Score_BestScore1);
        level2 = PlayerPrefs.GetInt(Score_BestScore2);
        level3 = PlayerPrefs.GetInt(Score_BestScore3);
        level4 = PlayerPrefs.GetInt(Score_BestScore4);
        level5 = PlayerPrefs.GetInt(Score_BestScore5);

        total = level1 + level2 + level3 + level4 + level5;

        float a = (float)total / (float)island1_Total_Score * 100f;
        int b = Mathf.RoundToInt(a);

        percentage.text = b + "%";
        Score = b;
        Fillpercent.fillAmount = a / 100 * 1;

    }

    public void Math_Number_Sense_Stage2_()
    {
        User_ID = PlayerPrefs.GetInt("account_is");

        Title.text = "NUMBER SENSE";
        string Score_BestScore1 = User_ID + "_Math_Number_Sense_Stage2_Level1_Score_BestScore";
        string Score_BestScore2 = User_ID + "_Math_Number_Sense_Stage2_Level2_Score_BestScore";
        string Score_BestScore3 = User_ID + "_Math_Number_Sense_Stage2_Level3_Score_BestScore";
        string Score_BestScore4 = User_ID + "_Math_Number_Sense_Stage2_Level4_Score_BestScore";
        string Score_BestScore5 = User_ID + "_Math_Number_Sense_Stage2_Level5_Score_BestScore";

        level1 = PlayerPrefs.GetInt(Score_BestScore1);
        level2 = PlayerPrefs.GetInt(Score_BestScore2);
        level3 = PlayerPrefs.GetInt(Score_BestScore3);
        level4 = PlayerPrefs.GetInt(Score_BestScore4);
        level5 = PlayerPrefs.GetInt(Score_BestScore5);

        total = level1 + level2 + level3 + level4 + level5;

        float a = (float)total / (float)island1_Total_Score * 100f;
        int b = Mathf.RoundToInt(a);

        percentage.text = b + "%";
        Score = b;
        Fillpercent.fillAmount = a / 100 * 1;

    }

    public void Math_Measurement_Stage3_()
    {
        User_ID = PlayerPrefs.GetInt("account_is");

        Title.text = "MEASUREMENT";

        string Score_BestScore1 = User_ID + "_Math_Measurement_Stage3_Level1_Score_BestScore";
        string Score_BestScore2 = User_ID + "_Math_Measurement_Stage3_Level2_Score_BestScore";
        string Score_BestScore3 = User_ID + "_Math_Measurement_Stage3_Level3_Score_BestScore";
        string Score_BestScore4 = User_ID + "_Math_Measurement_Stage3_Level4_Score_BestScore";
        string Score_BestScore5 = User_ID + "_Math_Measurement_Stage3_Level5_Score_BestScore";

        level1 = PlayerPrefs.GetInt(Score_BestScore1);
        level2 = PlayerPrefs.GetInt(Score_BestScore2);
        level3 = PlayerPrefs.GetInt(Score_BestScore3);
        level4 = PlayerPrefs.GetInt(Score_BestScore4);
        level5 = PlayerPrefs.GetInt(Score_BestScore5);

        total = level1 + level2 + level3 + level4 + level5;

        float a = (float)total / (float)island1_Total_Score * 100f;
        int b = Mathf.RoundToInt(a);

        percentage.text = b + "%";
        Score = b;
        Fillpercent.fillAmount = a / 100 * 1;

    }

    public void Math_Geometry_Stage4_()
    {
        User_ID = PlayerPrefs.GetInt("account_is");

        Title.text = "GEOMETRY";

        string Score_BestScore1 = User_ID + "_Math_Geometry_Stage4_Level1_Score_BestScore";
        string Score_BestScore2 = User_ID + "_Math_Geometry_Stage4_Level2_Score_BestScore";
        string Score_BestScore3 = User_ID + "_Math_Geometry_Stage4_Level3_Score_BestScore";
        string Score_BestScore4 = User_ID + "_Math_Geometry_Stage4_Level4_Score_BestScore";
        string Score_BestScore5 = User_ID + "_Math_Geometry_Stage4_Level5_Score_BestScore";

        level1 = PlayerPrefs.GetInt(Score_BestScore1);
        level2 = PlayerPrefs.GetInt(Score_BestScore2);
        level3 = PlayerPrefs.GetInt(Score_BestScore3);
        level4 = PlayerPrefs.GetInt(Score_BestScore4);
        level5 = PlayerPrefs.GetInt(Score_BestScore5);

        total = level1 + level2 + level3 + level4 + level5;

        float a = (float)total / (float)island1_Total_Score * 100f;
        int b = Mathf.RoundToInt(a);
        Score = b;
        percentage.text = b + "%";

        Fillpercent.fillAmount = a / 100 * 1;

    }

    public void Math_Stat_Prob_Stage5_()
    {
        User_ID = PlayerPrefs.GetInt("account_is");


        Title.text = "STAT & PROB";

        string Score_BestScore1 = User_ID + "_Math_Stat_Prob_Stage5_Level1_Score_BestScore";
        string Score_BestScore2 = User_ID + "_Math_Stat_Prob_Stage5_Level2_Score_BestScore";
        string Score_BestScore3 = User_ID + "_Math_Stat_Prob_Stage5_Level3_Score_BestScore";
        string Score_BestScore4 = User_ID + "_Math_Stat_Prob_Stage5_Level4_Score_BestScore";
        string Score_BestScore5 = User_ID + "_Math_Stat_Prob_Stage5_Level5_Score_BestScore";

        level1 = PlayerPrefs.GetInt(Score_BestScore1);
        level2 = PlayerPrefs.GetInt(Score_BestScore2);
        level3 = PlayerPrefs.GetInt(Score_BestScore3);
        level4 = PlayerPrefs.GetInt(Score_BestScore4);
        level5 = PlayerPrefs.GetInt(Score_BestScore5);

        total = level1 + level2 + level3 + level4 + level5;

        float a = (float)total / (float)island1_Total_Score * 100f;
        int b = Mathf.RoundToInt(a);
        Score = b;
        percentage.text = b + "%";

        Fillpercent.fillAmount = a / 100 * 1;
    }
    // Start is called before the first frame update
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;
    [SerializeField] private GameObject d;
    [SerializeField] private GameObject e;
    float Score;

    void Update()
    {


        if (Score < 74)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(true);
        }
        if (Score > 75 && Score < 80)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(true);
            e.SetActive(false);
        }
        if (Score > 79 && Score < 85)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(true);
            d.SetActive(false);
            e.SetActive(false);
        }
        if (Score > 84 && Score < 90)
        {
            a.SetActive(false);
            b.SetActive(true);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);
        }
        if (Score > 89)
        {
            a.SetActive(true);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);


        }
    }

}
