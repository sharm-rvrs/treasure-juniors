using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class testreturn : MonoBehaviour
{
    public GameObject character;
    public GameObject boat;
    public GameObject anchor2;
    public GameObject landing2;

    public GameObject Maincamera;
    public GameObject mathcoll2;
    public GameObject math2BTN;
    public GameObject backtomap;
    public GameObject BacktoWorldMap;
    public GameObject math2_cam_pos;
    float time_speed = 5;

    public GameObject CharOnBoat;

    bool math2 = false;


    private void Start()
    {
        int A = PlayerPrefs.GetInt("returnmath2");
        if(A == 1)
        {
            returnto();
        }


    }

    private void Update()
    {
        if(math2 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math2_cam_pos.transform.position, Time.deltaTime * time_speed);
        }
        
    }
    public void returnto()
    {
        
        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = landing2.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;

        

        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
        backtomap.SetActive(true);
        
        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay", 2f);
    }

    private void delay()
    {
        math2 = false;
    }
}
