using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HistoryView : MonoBehaviour
{
    [SerializeField] private string Subject_Topic_Stage_Level;
    [SerializeField] private TextMeshProUGUI Result_history;
    [SerializeField] private RectTransform Size;
    [SerializeField] private float Size_Per_try = 150;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Reset_History()
    {

        string a = "";
        string b = "";
        float size = 0;

        for (int i = 1; i >= 0; i++)
        {



            string Score_Result = Subject_Topic_Stage_Level + "_Score_Result_" + i;
            string Score_Time = Subject_Topic_Stage_Level + "_Score_Time_" + i;
            string Score_BestScore = Subject_Topic_Stage_Level + "_Score_BestScore";

            int Result = PlayerPrefs.GetInt(Score_Result);
            string Timer = PlayerPrefs.GetString(Score_Time);
            
            if (Timer != "")
            {

                   b =
                   "Game: " + i + "\n" +
                   "Score: " + Result + " Time: " + Timer + "\n" +
                    "" + "\n";
                a = a + b;
                size += Size_Per_try;
                Size.sizeDelta = new Vector2(Size.sizeDelta.x, size);
                Result_history.text = a;
                   

                Debug.Log(i);
            }
            else
            {
                Debug.Log("Stop");
                break;
            }


        }
    }
}
