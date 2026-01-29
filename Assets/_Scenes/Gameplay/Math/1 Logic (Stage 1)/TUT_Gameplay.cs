using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUT_Gameplay : MonoBehaviour
{

    int User_ID;
    int b;
    [SerializeField] private GameObject Tutorial_panel;
    [SerializeField] private GameObject point1;
    [SerializeField] private GameObject point2;
    [SerializeField] private GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        string t2 = User_ID + "_Tut_gameplay";

        b = PlayerPrefs.GetInt(t2);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (b == 1)
        {
            Tutorial_panel.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            block.SetActive(false);
        }
    }

    public void Tut_gameplay1()
    {
        User_ID = PlayerPrefs.GetInt("account_is");
        string t2 = User_ID + "_Tut_gameplay";
        PlayerPrefs.SetInt(t2,1);
    }
}
