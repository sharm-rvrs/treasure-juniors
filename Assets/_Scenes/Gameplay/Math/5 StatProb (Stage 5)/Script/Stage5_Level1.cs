using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage5_Level1 : MonoBehaviour
{
    // Start is called before the first frame update
    int correct = 0;


    [SerializeField] private Button Bcorrect;
    [SerializeField] private Button Button1;
    [SerializeField] private Button Button2;
    [SerializeField] private Button Button3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        correct = PlayerPrefs.GetInt("correct");
        
        

    }

    public void Button_correct()
    {
        Bcorrect.interactable = false;
        Button1.interactable = true;
        Button2.interactable = true;
        Button3.interactable = true;
        correct++;
        PlayerPrefs.SetInt("correct",correct);
    }

    public void Button_1()
    {
        Bcorrect.interactable = true;
        Button1.interactable = false;
        Button2.interactable = true;
        Button3.interactable = true;
        if(correct > 0)
        {
            correct--;
        }
       
    }

    public void Button_2()
    {
        Bcorrect.interactable = true;
        Button1.interactable = true;
        Button2.interactable = false;
        Button3.interactable = true;
        if (correct > 0)
        {
            correct--;
        }
    }

    public void Button_3()
    {
        Bcorrect.interactable = true;
        Button1.interactable = true;
        Button2.interactable = true;
        Button3.interactable = false;
        if (correct > 0)
        {
            correct--;
        }
    }

    

    

}
