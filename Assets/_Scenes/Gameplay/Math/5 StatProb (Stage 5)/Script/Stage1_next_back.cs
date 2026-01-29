using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_next_back : MonoBehaviour
{
    [SerializeField] private GameObject question1;
    [SerializeField] private GameObject question2;
    [SerializeField] private GameObject question3;
    [SerializeField] private GameObject question4;
    [SerializeField] private GameObject question5;

    [SerializeField] private GameObject submit;
    // Start is called before the first frame update

    int a = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1)
        {
            question1.SetActive(true);
        }
        else
        {
            question1.SetActive(false);
        }


        if (a == 2)
        {
            question2.SetActive(true);
        }
        else
        {
            question2.SetActive(false);
        }

        if (a == 3)
        {
            question3.SetActive(true);
        }
        else
        {
            question3.SetActive(false);
        }

        if (a == 4)
        {
            question4.SetActive(true);
        }
        else
        {
            question4.SetActive(false);
        }

        if (a == 5)
        {
            question5.SetActive(true);
        }
        else
        {
            question5.SetActive(false);
        }



        if (question5.activeInHierarchy)
        {
            submit.SetActive(true);
        }
        else
        {
            submit.SetActive(false);
        }

    }

    public void next()
    {
        if(a != 5)
        {
            a++;
        }
        
    }
    public void back()
    {
        if(a != 1)
        {
            a--;
        }
        
    }
}
