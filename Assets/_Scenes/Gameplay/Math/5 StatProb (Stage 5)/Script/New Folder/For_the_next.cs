using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_the_next : MonoBehaviour
{
    [SerializeField] private GameObject column2x6;
    [SerializeField] private GameObject nextbtn;
    [SerializeField] private GameObject backbtn;
    [SerializeField] private GameObject submitbtn;


    [SerializeField] private Animator Question1;
    [SerializeField] private Animator Question2;
    [SerializeField] private Animator Question3;

    [SerializeField] private GameObject item1;
    [SerializeField] private GameObject item2;
    [SerializeField] private GameObject item3;
    [SerializeField] private GameObject item4;
    [SerializeField] private GameObject item5;
    [SerializeField] private GameObject item6;
    [SerializeField] private GameObject item7;
    [SerializeField] private GameObject item8;
    [SerializeField] private GameObject item9;
    [SerializeField] private GameObject item10;
    [SerializeField] private GameObject item11;
    [SerializeField] private GameObject item12;
    int count = 0;

    private void Update()
    {
        if(item1.activeInHierarchy == false && item2.activeInHierarchy == false && item3.activeInHierarchy == false && item4.activeInHierarchy == false && item5.activeInHierarchy == false && item6.activeInHierarchy == false &&
            item7.activeInHierarchy == false && item8.activeInHierarchy == false && item9.activeInHierarchy == false && item10.activeInHierarchy == false && item11.activeInHierarchy == false && item12.activeInHierarchy == false)
        {
            if (count == 0)
            {
                nextbtn.SetActive(true);
                column2x6.SetActive(false);
                Question1.SetBool("next", true);
                count++;
                Debug.Log(count);
                return;
            }
        }
    }
    public void Next_BTN()
    {
        
        if(count == 1)
        {
            Question1.SetBool("next", false);
            Question1.SetBool("back", false);
            Question1.SetBool("next_next", true);
            Question2.SetBool("back_back", false);
            Question2.SetBool("next", true);
            Question2.SetBool("back", false);
            backbtn.SetActive(true);
            count++;
            Debug.Log(count);
            return;
        }
        if(count == 2)
        {
            Question1.SetBool("next_next", false);
            Question1.SetBool("back", false);
            Question2.SetBool("back", false);
            Question2.SetBool("next", false);
            Question2.SetBool("next_next", true);
            Question3.SetBool("next", true);
            Question3.SetBool("back_back", false);

            submitbtn.SetActive(true);
            nextbtn.SetActive(false);
            count++;
            Debug.Log(count);
            return;
        }
        Debug.Log(count);
    }

    public void Back_BTN()
    {
       

        if(count == 3)
        {
           
            Question2.SetBool("next_next", false);
            
            Question2.SetBool("back", true);
            Question3.SetBool("next", false);
            Question3.SetBool("back_back", true);
            submitbtn.SetActive(false);
            nextbtn.SetActive(true);
            count--;
            Debug.Log(count);
            return;
        }

        if(count == 2)
        {
            Question2.SetBool("next", false);
            Question2.SetBool("back", false);
            Question2.SetBool("back_back", true);
            Question1.SetBool("next_next",false);
            Question1.SetBool("back", true);
            backbtn.SetActive(false);
            count--;
            Debug.Log(count);
            
            return;
        }
        
    }

}
