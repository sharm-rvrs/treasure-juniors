using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boatmove : MonoBehaviour
{
    public Vector3 targetmath;
    public Vector3 targetscience;
    public NavMeshAgent boat;


    // Start is called before the first frame update
    void Start()
    {
        
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
                boat.SetDestination(hit.point);
            }
        }
    }

    public void movetomath()
    {

    }

    public void movetoscience()
    {

    }

}

