using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class transition : MonoBehaviour
{
    [SerializeField] private GameObject nextBTN;
    [SerializeField] private GameObject backBTN;
    [SerializeField] private GameObject submitBTN;
    [SerializeField] private Animator next_anim;
    [SerializeField] private AudioSource first_Sound;
    [SerializeField] private AudioSource second_Sound;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string first_text;
    [SerializeField] private string second_text;
    int next = 0;



    public void next_to_level5()
    {

        next += 1;

        if (next == 1)
        {
            next_anim.Play("next_1");
            backBTN.SetActive(true);
            text.text = first_text;

        }

        if (next == 2)
        {
            next_anim.Play("next_2");
            submitBTN.SetActive(true);
            nextBTN.SetActive(false);
            text.text = second_text;
            first_Sound.Stop();
            second_Sound.Play();
        }
        if (next == 3)
        {
            next = 2;
        }

    }

    public void back_to_level5()
    {





        if (next == 1)
        {
            next_anim.Play("back_1");
            backBTN.SetActive(false);
            next -= 1;
            text.text = first_text;
            first_Sound.Play();
        }

        if (next == 2)
        {
            next_anim.Play("back_2");
            submitBTN.SetActive(false);
            nextBTN.SetActive(true);
            text.text = first_text;

            second_Sound.Stop();
            next -= 1;
        }

    }

    public void Replay_Instruction()
    {
        if (next == 1 || next == 0)
        {
            first_Sound.Play();
            second_Sound.Stop();
        }
        if (next == 2)
        {
            first_Sound.Stop();
            second_Sound.Play();
        }
    }

}
