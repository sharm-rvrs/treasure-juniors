using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Play_Instruction : MonoBehaviour
{
    [SerializeField] private AudioSource Clips1;
    [SerializeField] private AudioSource Clips2;

    [SerializeField] private GameObject next;
    [SerializeField] private GameObject back;

    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private string first_text;
    [SerializeField] private string second_text;

    private void Update()
    {
        if (next.activeInHierarchy == true)
        {
            text.text = first_text;
        }
        if (back.activeInHierarchy == true)
        {
            text.text = second_text;
        }
    }
    public void Play_Instruction_Sound()
    {
       if(next.activeInHierarchy == true)
        {
            Clips1.Play();
        }
        if (back.activeInHierarchy == true)
        {
            Clips2.Play();
        }
    }

   
}
