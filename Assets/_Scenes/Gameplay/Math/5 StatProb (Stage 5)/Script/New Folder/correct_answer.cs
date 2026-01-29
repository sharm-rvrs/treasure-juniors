using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correct_answer : MonoBehaviour
{
    [SerializeField] private Button Q1_A;
    [SerializeField] private Button Q1_B;
    [SerializeField] private Button Q1_C;

    [SerializeField] private Button Q2_A;
    [SerializeField] private Button Q2_B;
    [SerializeField] private Button Q2_C;
    [SerializeField] private Button Q2_D;

    [SerializeField] private Button Q3_A;
    [SerializeField] private Button Q3_B;
    [SerializeField] private Button Q3_C;
    [SerializeField] private Button Q3_D;

    int score = 0;

    public void BTN1_A()
    {
        Q1_A.interactable = false;
        Q1_B.interactable = true;
        Q1_C.interactable = true;
    }

    public void BTN1_B()
    {
        Q1_A.interactable = true;
        Q1_B.interactable = false;
        Q1_C.interactable = true;
    }

    public void BTN1_C()
    {
        Q1_A.interactable = true;
        Q1_B.interactable = true;
        Q1_C.interactable = false;
    }

    //===================================

    public void BTN2_A()
    {
        Q2_A.interactable = false;
        Q2_B.interactable = true;
        Q2_C.interactable = true;
        Q2_D.interactable = true;
    }

    public void BTN2_B()
    {
        Q2_A.interactable = true;
        Q2_B.interactable = false;
        Q2_C.interactable = true;
        Q2_D.interactable = true;
    }
    public void BTN2_C()
    {
        Q2_A.interactable = true;
        Q2_B.interactable = true;
        Q2_C.interactable = false;
        Q2_D.interactable = true;
    }

    public void BTN2_D()
    {
        Q2_A.interactable = true;
        Q2_B.interactable = true;
        Q2_C.interactable = true;
        Q2_D.interactable = false;
    }

    //===========================================

    public void BTN3_A()
    {
        Q3_A.interactable = false;
        Q3_B.interactable = true;
        Q3_C.interactable = true;
        Q3_D.interactable = true;
    }

    public void BTN3_B()
    {
        Q3_A.interactable = true;
        Q3_B.interactable = false;
        Q3_C.interactable = true;
        Q3_D.interactable = true;
    }

    public void BTN3_C()
    {
        Q3_A.interactable = true;
        Q3_B.interactable = true;
        Q3_C.interactable = false;
        Q3_D.interactable = true;
    }

    public void BTN3_D()
    {
        Q3_A.interactable = true;
        Q3_B.interactable = true;
        Q3_C.interactable = true;
        Q3_D.interactable = false;
    }

    public void Collect_Score()
    {
        if(Q1_A.interactable == false)
        {
            score++;
        }
        if (Q2_C.interactable == false)
        {
            score++;
        }
        if (Q3_B.interactable == false)
        {
            score++;
        }

        PlayerPrefs.SetInt("correct", score);
    }
}
