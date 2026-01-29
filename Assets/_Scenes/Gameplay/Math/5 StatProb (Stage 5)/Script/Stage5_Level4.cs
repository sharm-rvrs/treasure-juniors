using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage5_Level4 : MonoBehaviour
{
    [SerializeField] private Animator BTN_1;
    [SerializeField] private Animator BTN_2;
    [SerializeField] private Animator BTN_3;
    [SerializeField] private Animator BTN_4;
    [SerializeField] private Animator BTN_5;
    [SerializeField] private Animator BTN_6;
    [SerializeField] private Animator BTN_7;

    [SerializeField] private GameObject nextBTN;
    [SerializeField] private GameObject submitBTN;

    [SerializeField] private Animator first;
    [SerializeField] private Animator second;
    int count = 0;
    int score = 0;
    [SerializeField] private AudioSource error;

    [SerializeField] private AudioSource second_sound;
    [SerializeField] private AudioSource first_sound;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    public void Button_1()
    {
       
        if (BTN_1.GetBool("isClick")== true)
        {
            BTN_1.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_1.GetBool("isClick")== false)
        {
            BTN_1.SetBool("isClick", true);
            count++;
        }

        
        
    }

    public void Button_2()
    {
        if (BTN_2.GetBool("isClick") == true)
        {
            BTN_2.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_2.GetBool("isClick") == false)
        {
            BTN_2.SetBool("isClick", true);
            count++;
        }
    }

    public void Button_3()
    {
        if (BTN_3.GetBool("isClick") == true)
        {
            BTN_3.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_3.GetBool("isClick") == false)
        {
            BTN_3.SetBool("isClick", true);
            count++;
        }
    }

    public void Button_4()
    {
        if (BTN_4.GetBool("isClick") == true)
        {
            BTN_4.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_4.GetBool("isClick") == false)
        {
            BTN_4.SetBool("isClick", true);
            count++;
        }
    }

    public void Button_5()
    {
        if (BTN_5.GetBool("isClick") == true)
        {
            BTN_5.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_5.GetBool("isClick") == false)
        {
            BTN_5.SetBool("isClick", true);
            count++;
        }
    }

    public void Button_6()
    {
        if (BTN_6.GetBool("isClick") == true)
        {
            BTN_6.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_6.GetBool("isClick") == false)
        {
            BTN_6.SetBool("isClick", true);
            count++;
        }
    }

    public void Button_7()
    {
        if (BTN_7.GetBool("isClick") == true)
        {
            BTN_7.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 3 && BTN_7.GetBool("isClick") == false)
        {
            BTN_7.SetBool("isClick", true);
            count++;
        }
    }

    public void GetScore()
    {
        if(count < 3)
        {
            error.Play();
            return;
        }
        nextBTN.SetActive(false);
        submitBTN.SetActive(true);
        first.SetBool("next", true);
        second.SetBool("next", true);
        second_sound.Play();
        first_sound.Stop();

        if (BTN_1.GetBool("isClick") == true)
        {
            score++;
        }
        if (BTN_2.GetBool("isClick") == true)
        {
            score++;
        }
        if (BTN_3.GetBool("isClick") == true)
        {
            score++;
        }

        PlayerPrefs.SetInt("correct", score);
    }

}
