using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story_chest : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator chest;


    private void Start()
    {
        chest.Play("open");
    }
}
