using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Ph2 : MonoBehaviour
{
    [SerializeField] private GameObject first_object;
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private GameObject object3;
    [SerializeField] private GameObject object4;

    [SerializeField] private GameObject Tutorial_Panel;

    [SerializeField] private GameObject pointer;
    [SerializeField] private GameObject pointer2;
    [SerializeField] private GameObject pointer3;
    [SerializeField] private GameObject BTN;

    [SerializeField] private GameObject block;

    bool phase1 = true;
    bool phase2 = true;

    int User_ID;
    int b;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(phase1 == true)
        {
            if (first_object.activeInHierarchy == false)
            {


                //Tutorial_Panel.SetActive(true);
                pointer.SetActive(false);
                pointer2.SetActive(true);
                BTN.SetActive(false);
                phase1 = false;
            }
        }

        if (phase2 == true)
        {

            User_ID = PlayerPrefs.GetInt("account_is");
            string t2 = User_ID + "_Tut_gameplay";

            b = PlayerPrefs.GetInt(t2);

            if(b == 0)
            {
                if (object1.activeInHierarchy == false && object2.activeInHierarchy == false && object3.activeInHierarchy == false && object4.activeInHierarchy == false)
                {
                    pointer3.SetActive(true);
                    Tutorial_Panel.SetActive(true);
                    block.SetActive(false);
                    phase2 = false;
                }
            }
           
        }

        
    }


    public void close_pointer2()
    {
        pointer2.SetActive(false);
        Tutorial_Panel.SetActive(false);
    }

    public void close_pointer3()
    {
        pointer3.SetActive(false);
        
    }
}
