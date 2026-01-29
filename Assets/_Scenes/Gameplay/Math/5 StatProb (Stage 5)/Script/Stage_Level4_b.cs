using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage_Level4_b : MonoBehaviour
{
    [SerializeField] private Animator BTN_1;
    [SerializeField] private Animator BTN_2;
    [SerializeField] private Animator BTN_3;
    [SerializeField] private Animator BTN_4;
    [SerializeField] private Animator BTN_5;
    [SerializeField] private Animator BTN_6;
    [SerializeField] private Animator BTN_7;

    int count = 0;
    int score = 0;

    // Start is called before the first frame update

    [SerializeField] private GameObject Pause_Panel;
    [SerializeField] private GameObject Submit_Confirm_Panel;
    [SerializeField] private GameObject blurred;
    [SerializeField] private string Subject_Topic_Stage_Level;

    [SerializeField] private AudioSource error;



    public void Pause()
    {
        Pause_Panel.SetActive(true);
        blurred.SetActive(true);
    }

    public void Resume_to_gameplay()
    {
        Pause_Panel.SetActive(false);
        blurred.SetActive(false);
    }

    public void Confirm_Submit_Panel()
    {

        if (count < 4)
        {
            error.Play();
            return;
        }

        Submit_Confirm_Panel.SetActive(true);
        blurred.SetActive(true);
    }

    public void Confirm_No_Submit_Panel()
    {
        Submit_Confirm_Panel.SetActive(false);
        blurred.SetActive(false);
    }

    public void Restart_Gameplay()
    {
        SceneManager.LoadScene(Subject_Topic_Stage_Level);
    }


    void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    public void Button_1()
    {

        if (BTN_1.GetBool("isClick") == true)
        {
            BTN_1.SetBool("isClick", false);
            count--;
            return;
        }
        if (count < 4 && BTN_1.GetBool("isClick") == false)
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
        if (count < 4 && BTN_2.GetBool("isClick") == false)
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
        if (count < 4 && BTN_3.GetBool("isClick") == false)
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
        if (count < 4 && BTN_4.GetBool("isClick") == false)
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
        if (count < 4 && BTN_5.GetBool("isClick") == false)
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
        if (count < 4 && BTN_6.GetBool("isClick") == false)
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
        if (count < 4 && BTN_7.GetBool("isClick") == false)
        {
            BTN_7.SetBool("isClick", true);
            count++;
        }
    }

    public void GetScore()
    {
      
        

        if (BTN_4.GetBool("isClick") == true)
        {
            score++;
        }
        if (BTN_5.GetBool("isClick") == true)
        {
            score++;
        }
        if (BTN_6.GetBool("isClick") == true)
        {
            score++;
        }
        if (BTN_7.GetBool("isClick") == true)
        {
            score++;
        }
        int a = PlayerPrefs.GetInt("correct");
        score += a;
        PlayerPrefs.SetInt("correct", score);
    }

}
