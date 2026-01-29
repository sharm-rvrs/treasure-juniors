using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{

    [SerializeField] private Button BTN_A_1;
    [SerializeField] private Button BTN_B_1;

    [SerializeField] private Button BTN_A_2;
    [SerializeField] private Button BTN_B_2;

    [SerializeField] private Button BTN_A_3;
    [SerializeField] private Button BTN_B_3;

    int correct;

    private void Start()
    {
        PlayerPrefs.SetInt("correct", 0);
    }

    // Start is called before the first frame update
    public void Choices_BTN_A_1()
    {
        BTN_A_1.interactable = false;
        BTN_B_1.interactable = true;
        
    }

    public void Choices_BTN_B_1()
    {
        BTN_A_1.interactable = true;
        BTN_B_1.interactable = false;
    }

    //=========================

    public void Choices_BTN_A_2()
    {
        BTN_A_2.interactable = false;
        BTN_B_2.interactable = true;

    }

    public void Choices_BTN_B_2()
    {
        BTN_A_2.interactable = true;
        BTN_B_2.interactable = false;

    }

    //===========================

    public void Choices_BTN_A_3()
    {
        BTN_A_3.interactable = false;
        BTN_B_3.interactable = true;

    }

    public void Choices_BTN_B_3()
    {
        BTN_A_3.interactable = true;
        BTN_B_3.interactable = false;
    }

    public void Collect_Score()
    {

        
        if(BTN_A_1.interactable == false)
        { 
            correct++;    
        }

        if(BTN_B_2.interactable == false)
        {
            correct++;
        }

        if(BTN_A_3.interactable == false)
        {
            correct++;
        }
        int a = PlayerPrefs.GetInt("correct");
        correct += a;
        PlayerPrefs.SetInt("correct", correct);
    }
}
