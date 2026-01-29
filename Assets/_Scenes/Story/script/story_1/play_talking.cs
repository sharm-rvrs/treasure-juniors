using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_talking : MonoBehaviour
{
    [SerializeField] private Animator boy_Anim;
    [SerializeField] private Animator girl_Anim;
    public void Talking()
    {
        boy_Anim.Play("Talking");
        girl_Anim.Play("Talking");

    }
}
