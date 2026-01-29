using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharToMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator Char;
    public AudioSource CharRunSound;
    float a;

    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetFloat("Global_BG_Volume");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
        if (agent.hasPath)
        {
            Char.SetBool("Run", true);
            CharRunSound.volume = a;
        }
        else
        {
            Char.SetBool("Run", false);
            CharRunSound.volume = 0;
        }
    }
}
