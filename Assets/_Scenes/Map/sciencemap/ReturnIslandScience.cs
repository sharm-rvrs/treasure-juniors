using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ReturnIslandScience : MonoBehaviour
{
    public GameObject character;
    public GameObject boat;

    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject anchor3;


    public GameObject island1_LVL1_point;
    public GameObject island1_LVL2_point;
    public GameObject island1_LVL3_point;
    public GameObject island1_LVL4_point;
    public GameObject island1_LVL5_point;

    public GameObject island2_LVL1_point;
    public GameObject island2_LVL2_point;
    public GameObject island2_LVL3_point;
    public GameObject island2_LVL4_point;
    public GameObject island2_LVL5_point;

    public GameObject island3_LVL1_point;
    public GameObject island3_LVL2_point;
    public GameObject island3_LVL3_point;
    public GameObject island3_LVL4_point;
    public GameObject island3_LVL5_point;



    public GameObject sciencecoll1;
    public GameObject sciencecoll2;
    public GameObject sciencecoll3;


    public GameObject science1BTN;
    public GameObject science2BTN;
    public GameObject science3BTN;


    public GameObject Maincamera;

    public GameObject backtomap;
    public GameObject BacktoWorldMap;

    public GameObject science1_cam_pos;
    public GameObject science2_cam_pos;
    public GameObject science3_cam_pos;

    float time_speed = 5;

    public GameObject CharOnBoat;

    [Header("lock")]
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
   

    bool science1 = false;
    bool science2 = false;
    bool science3 = false;



    private void Start()
    {
        int return_island1_LVL1 = PlayerPrefs.GetInt("return_island1_LVL1");
        int return_island1_LVL2 = PlayerPrefs.GetInt("return_island1_LVL2");
        int return_island1_LVL3 = PlayerPrefs.GetInt("return_island1_LVL3");
        int return_island1_LVL4 = PlayerPrefs.GetInt("return_island1_LVL4");
        int return_island1_LVL5 = PlayerPrefs.GetInt("return_island1_LVL5");

        int return_island2_LVL1 = PlayerPrefs.GetInt("return_island2_LVL1");
        int return_island2_LVL2 = PlayerPrefs.GetInt("return_island2_LVL2");
        int return_island2_LVL3 = PlayerPrefs.GetInt("return_island2_LVL3");
        int return_island2_LVL4 = PlayerPrefs.GetInt("return_island2_LVL4");
        int return_island2_LVL5 = PlayerPrefs.GetInt("return_island2_LVL5");

        int return_island3_LVL1 = PlayerPrefs.GetInt("return_island3_LVL1");
        int return_island3_LVL2 = PlayerPrefs.GetInt("return_island3_LVL2");
        int return_island3_LVL3 = PlayerPrefs.GetInt("return_island3_LVL3");
        int return_island3_LVL4 = PlayerPrefs.GetInt("return_island3_LVL4");
        int return_island3_LVL5 = PlayerPrefs.GetInt("return_island3_LVL5");




        //============================================================================================
        sciencecoll2.SetActive(false);
        sciencecoll3.SetActive(false);

        if (return_island1_LVL1 == 1)
        {
            returnto_island1_LVL1();
            lock_btn();

        }
        if (return_island1_LVL2 == 1)
        {
            returnto_island1_LVL2(); 
            lock_btn();
        }
        if (return_island1_LVL3 == 1)
        {
            returnto_island1_LVL3(); 
            lock_btn();
        }
        if (return_island1_LVL4 == 1)
        {
            returnto_island1_LVL4(); 
            lock_btn();
        }
        if (return_island1_LVL5 == 1)
        {
            returnto_island1_LVL5(); 
            lock_btn();
        }

        if (return_island2_LVL1 == 1)
        {
            returnto_island2_LVL1(); 
            lock_btn();
            science2BTN.SetActive(false);
        }
        if (return_island2_LVL2 == 1)
        {
            returnto_island2_LVL2();
            lock_btn();
        }
        if (return_island2_LVL3 == 1)
        {
            returnto_island2_LVL3();
            lock_btn();
        }
        if (return_island2_LVL4 == 1)
        {
            returnto_island2_LVL4(); 
            lock_btn();
        }
        if (return_island2_LVL5 == 1)
        {
            returnto_island2_LVL5(); 
            lock_btn();
        }

        if (return_island3_LVL1 == 1)
        {
            returnto_island3_LVL1(); 
            lock_btn();
        }
        if (return_island3_LVL2 == 1)
        {
            returnto_island3_LVL2();
            lock_btn();
        }
        if (return_island3_LVL3 == 1)
        {
            returnto_island3_LVL3(); 
            lock_btn();
        }
        if (return_island3_LVL4 == 1)
        {
            returnto_island3_LVL4(); 
            lock_btn();
        }
        if (return_island3_LVL5 == 1)
        {
            returnto_island3_LVL5();
            lock_btn();
        }

        

        PlayerPrefs.SetInt("return_island1_LVL1", 0);
        PlayerPrefs.SetInt("return_island1_LVL2", 0);
        PlayerPrefs.SetInt("return_island1_LVL3", 0);
        PlayerPrefs.SetInt("return_island1_LVL4", 0);
        PlayerPrefs.SetInt("return_island1_LVL5", 0);

        PlayerPrefs.SetInt("return_island2_LVL1", 0);
        PlayerPrefs.SetInt("return_island2_LVL2", 0);
        PlayerPrefs.SetInt("return_island2_LVL3", 0);
        PlayerPrefs.SetInt("return_island2_LVL4", 0);
        PlayerPrefs.SetInt("return_island2_LVL5", 0);

        PlayerPrefs.SetInt("return_island3_LVL1", 0);
        PlayerPrefs.SetInt("return_island3_LVL2", 0);
        PlayerPrefs.SetInt("return_island3_LVL3", 0);
        PlayerPrefs.SetInt("return_island3_LVL4", 0);
        PlayerPrefs.SetInt("return_island3_LVL5", 0);


        

    }

    private void Update()
    {
        if (science1 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science1_cam_pos.transform.position, Time.deltaTime * time_speed);
            
        }
        if (science2 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science2_cam_pos.transform.position, Time.deltaTime * time_speed);
            sciencecoll2.SetActive(false);
            science2BTN.SetActive(false);


        }
        if (science3 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science3_cam_pos.transform.position, Time.deltaTime * time_speed);
            sciencecoll3.SetActive(false);
            science3BTN.SetActive(false);

        }
       
    }

    void lock_btn()
    {
        lock2.SetActive(false);
        lock3.SetActive(false);
       
    }
    public void returnto_island1_LVL1()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island1_LVL1_point.transform.position;
        Vector3 b = anchor1.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science1 = true;
        sciencecoll1.SetActive(false);
        science1BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay1", 2f);
    }
    public void returnto_island1_LVL2()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island1_LVL2_point.transform.position;
        Vector3 b = anchor1.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science1 = true;
        sciencecoll1.SetActive(false);
        science1BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay1", 2f);
    }
    public void returnto_island1_LVL3()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island1_LVL3_point.transform.position;
        Vector3 b = anchor1.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science1 = true;
        sciencecoll1.SetActive(false);
        science1BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay1", 2f);
    }
    public void returnto_island1_LVL4()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island1_LVL4_point.transform.position;
        Vector3 b = anchor1.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;

        science1 = true;
        sciencecoll1.SetActive(false);
        science1BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay1", 2f);
    }
    public void returnto_island1_LVL5()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island1_LVL5_point.transform.position;
        Vector3 b = anchor1.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;

        science1 = true;
        sciencecoll1.SetActive(false);
        science1BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay1", 2f);
    }

    public void returnto_island2_LVL1()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island2_LVL1_point.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science2 = true;
        sciencecoll2.SetActive(false);
        science2BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay2", 2f);
    }
    public void returnto_island2_LVL2()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island2_LVL2_point.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science2 = true;
        sciencecoll2.SetActive(false);
        science2BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay2", 2f);
    }
    public void returnto_island2_LVL3()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island2_LVL3_point.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science2 = true;
        sciencecoll2.SetActive(false);
        science2BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay2", 2f);
    }
    public void returnto_island2_LVL4()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island2_LVL4_point.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science2 = true;
        sciencecoll2.SetActive(false);
        science2BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay2", 2f);
    }
    public void returnto_island2_LVL5()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island2_LVL5_point.transform.position;
        Vector3 b = anchor2.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science2 = true;
        sciencecoll2.SetActive(false);
        science2BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay2", 2f);
    }

    public void returnto_island3_LVL1()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island3_LVL1_point.transform.position;
        Vector3 b = anchor3.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science3 = true;
        sciencecoll3.SetActive(false);
        science3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }
    public void returnto_island3_LVL2()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island3_LVL2_point.transform.position;
        Vector3 b = anchor3.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science3 = true;
        sciencecoll3.SetActive(false);
        science3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }
    public void returnto_island3_LVL3()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island3_LVL3_point.transform.position;
        Vector3 b = anchor3.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science3 = true;
        sciencecoll3.SetActive(false);
        science3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }
    public void returnto_island3_LVL4()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island3_LVL4_point.transform.position;
        Vector3 b = anchor3.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science3 = true;
        sciencecoll3.SetActive(false);
        science3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }
    public void returnto_island3_LVL5()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island3_LVL5_point.transform.position;
        Vector3 b = anchor3.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        science3 = true;
        sciencecoll3.SetActive(false);
        science3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }

  

    //----------------------------------------------------------------------------------------------
    private void delay1()
    {
        science1 = false;
    }
    private void delay2()
    {
        science2 = false;
    }
    private void delay3()
    {
        science3 = false;
    }
  
}
