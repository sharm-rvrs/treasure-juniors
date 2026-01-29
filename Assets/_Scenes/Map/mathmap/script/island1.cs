using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class island1 : MonoBehaviour
{

    public GameObject character;
    public GameObject Landing;
    public GameObject CharOnBoat;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "boat")
        {
            character.SetActive(true);
            character.GetComponent<NavMeshAgent>().enabled = false;
            Vector3 a = Landing.transform.position;
            character.transform.position = (a);
            character.GetComponent<NavMeshAgent>().enabled = true;
            CharOnBoat.SetActive(false);

        }
    }
   
}
