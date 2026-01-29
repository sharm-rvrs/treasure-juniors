using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class In_or_Out : MonoBehaviour
{
   
    [SerializeField] private Button Button1_1;
    [SerializeField] private Button Button1_2;

    [SerializeField] private Button Button2_1;
    [SerializeField] private Button Button2_2;

    [SerializeField] private Button Button3_1;
    [SerializeField] private Button Button3_2;

    [SerializeField] private Button Button4_1;
    [SerializeField] private Button Button4_2;

    int score = 0;
    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    // question1
   public void Button_1_1()
    {
        Button1_1.interactable = false;
        Button1_2.interactable = true;

    }

    public void Button_1_2()
    {
        Button1_1.interactable = true;
        Button1_2.interactable = false;

    }

    // question2
    public void Button_2_1()
    {
        Button2_1.interactable = false;
        Button2_2.interactable = true;

    }

    public void Button_2_2()
    {
        Button2_1.interactable = true;
        Button2_2.interactable = false;

    }

    // question3
    public void Button_3_1()
    {
        Button3_1.interactable = false;
        Button3_2.interactable = true;

    }

    public void Button_3_2()
    {
        Button3_1.interactable = true;
        Button3_2.interactable = false;

    }

    // question4
    public void Button_4_1()
    {
        Button4_1.interactable = false;
        Button4_2.interactable = true;

    }

    public void Button_4_2()
    {
        Button4_1.interactable = true;
        Button4_2.interactable = false;

    }


    public void Collect_Score()
    {
        if(Button1_1.interactable == false)
        {
            score++;
        }

        if (Button2_2.interactable == false)
        {
            score++;
        }

        if (Button3_1.interactable == false)
        {
            score++;
        }

        if (Button4_2.interactable == false)
        {
            score++;
        }

        PlayerPrefs.SetInt("correct", score);
    }

}
