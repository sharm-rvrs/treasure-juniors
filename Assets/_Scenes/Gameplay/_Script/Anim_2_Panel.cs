using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_2_Panel : MonoBehaviour
{
    [SerializeField] private Animator first;
    [SerializeField] private Animator Second;
    [SerializeField] private GameObject SubmitBTN;
    [SerializeField] private GameObject NextBTN;
    [SerializeField] private GameObject backBTN;

    [SerializeField] private AudioSource first_sound;
    [SerializeField] private AudioSource second_sound;



    public void Next_Panel()
    {
        first.Play("next");
        Second.Play("next");
        SubmitBTN.SetActive(true);
        NextBTN.SetActive(false);
        backBTN.SetActive(true);
        first_sound.Stop();
        second_sound.Play();
    }

    public void Back_Panel()
    {
        first.Play("back");
        Second.Play("back");
        SubmitBTN.SetActive(false);
        NextBTN.SetActive(true);
        backBTN.SetActive(false);
        first_sound.Play();
        second_sound.Stop();
    }

}
