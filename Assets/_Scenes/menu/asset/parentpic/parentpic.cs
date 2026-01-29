using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parentpic : MonoBehaviour
{
    [SerializeField] private GameObject Parent_Pic;
    [SerializeField] private Sprite[] pic;
    [SerializeField] private Button[] BTNpic;
    
    int a = 0;
   

    void Start()
    {
        a = PlayerPrefs.GetInt("Parent_Picture");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickpic1()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[1].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 1);
    }
    public void clickpic2()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[2].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 2);
    }
    public void clickpic3()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[3].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 3);
    }
    public void clickpic4()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[4].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 4);
    }
    public void clickpic5()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[5].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 5);
    }
    public void clickpic6()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[6].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 6);
    }
    public void clickpic7()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[7].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 7);
    }
    public void clickpic8()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[8].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 8);
    }
    public void clickpic9()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[9].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 9);
    }
    public void clickpic10()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[10].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 10);
    }
    public void clickpic11()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[11].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 11);
    }
    public void clickpic12()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[12].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 12);
    }
    public void clickpic13()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[13].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 13);
    }
    public void clickpic14()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[14].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 14);
    }
    public void clickpic15()
    {
        for (int i = 0; i <= 15; i++)
        {
            BTNpic[i].interactable = true;
        }

        BTNpic[15].interactable = false;
        PlayerPrefs.SetInt("Parent_Picture", 15);
    }
    public void done_pic()
    {
        a = PlayerPrefs.GetInt("Parent_Picture");

        Parent_Pic.GetComponent<Image>().sprite = pic[a];

        
    }
}
