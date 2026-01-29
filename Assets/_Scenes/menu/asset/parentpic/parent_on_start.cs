using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parent_on_start : MonoBehaviour
{
    [SerializeField] private GameObject Parent_Pic;
    [SerializeField] private Sprite[] pic;
    int a = 0;
    void Start()
    {
        a = PlayerPrefs.GetInt("Parent_Picture");

        Parent_Pic.GetComponent<Image>().sprite = pic[a];
    }

    // Update is called once per frame
    void Update()
    {
        a = PlayerPrefs.GetInt("Parent_Picture");

        Parent_Pic.GetComponent<Image>().sprite = pic[a];
    }
}

