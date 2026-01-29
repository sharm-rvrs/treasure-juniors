using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_2_Phase : MonoBehaviour
{
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;

    [SerializeField] private float time;
    private void OnEnable()
    {
        Invoke("nexttext", time);
    }


    void nexttext()
    {
        text2.SetActive(true);
        text1.SetActive(false);
    }
}
