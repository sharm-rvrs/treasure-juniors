using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ReturnToIsland : MonoBehaviour
{
    public GameObject character;
    public GameObject boat;

    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject anchor3;
    public GameObject anchor4;
    public GameObject anchor5;

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

    public GameObject island4_LVL1_point;
    public GameObject island4_LVL2_point;
    public GameObject island4_LVL3_point;
    public GameObject island4_LVL4_point;
    public GameObject island4_LVL5_point;

    public GameObject island5_LVL1_point;
    public GameObject island5_LVL2_point;
    public GameObject island5_LVL3_point;
    public GameObject island5_LVL4_point;
    public GameObject island5_LVL5_point;

    public GameObject mathcoll1;
    public GameObject mathcoll2;
    public GameObject mathcoll3;
    public GameObject mathcoll4;
    public GameObject mathcoll5;

    public GameObject math1BTN;
    public GameObject math2BTN;
    public GameObject math3BTN;
    public GameObject math4BTN;
    public GameObject math5BTN;

    public GameObject Maincamera;
    
    public GameObject backtomap;
    public GameObject BacktoWorldMap;

    public GameObject math1_cam_pos;
    public GameObject math2_cam_pos;
    public GameObject math3_cam_pos;
    public GameObject math4_cam_pos;
    public GameObject math5_cam_pos;
    float time_speed = 5;

    public GameObject CharOnBoat;

    [Header("lock")]
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private GameObject lock4;
    [SerializeField] private GameObject lock5;

    bool math1 = false;
    bool math2 = false;
    bool math3 = false;
    bool math4 = false;
    bool math5 = false;

    [SerializeField] private GameObject first_chest_island2;
    [SerializeField] private GameObject first_chest_island3;
    [SerializeField] private GameObject first_chest_island4;
    [SerializeField] private GameObject first_chest_island5;

    private void Start()
    {


        //if (first_chest_island2.activeInHierarchy == true)
        //{
        //    lock2.SetActive(false);
        //    Debug.Log("present");

        //}


        //if (first_chest_island3.activeInHierarchy == true)
        //{
        //    lock3.SetActive(false);


        //}
        //else
        //{
        //    mathcoll3.SetActive(false);
        //}

        //if (first_chest_island4.activeInHierarchy == true)
        //{
        //    lock4.SetActive(false);

        //}
        //else
        //{
        //    mathcoll4.SetActive(false);
        //}

        //if (first_chest_island5.activeInHierarchy == true)
        //{
        //    lock5.SetActive(false);


        //}
        //else
        //{
        //    mathcoll5.SetActive(false);
        //}
      

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

        int return_island4_LVL1 = PlayerPrefs.GetInt("return_island4_LVL1");
        int return_island4_LVL2 = PlayerPrefs.GetInt("return_island4_LVL2");
        int return_island4_LVL3 = PlayerPrefs.GetInt("return_island4_LVL3");
        int return_island4_LVL4 = PlayerPrefs.GetInt("return_island4_LVL4");
        int return_island4_LVL5 = PlayerPrefs.GetInt("return_island4_LVL5");

        int return_island5_LVL1 = PlayerPrefs.GetInt("return_island5_LVL1");
        int return_island5_LVL2 = PlayerPrefs.GetInt("return_island5_LVL2");
        int return_island5_LVL3 = PlayerPrefs.GetInt("return_island5_LVL3");
        int return_island5_LVL4 = PlayerPrefs.GetInt("return_island5_LVL4");
        int return_island5_LVL5 = PlayerPrefs.GetInt("return_island5_LVL5");


        //============================================================================================

        if (return_island1_LVL1 == 1)
        {
            lock_btn();
            returnto_island1_LVL1();
        }
        if (return_island1_LVL2 == 1)
        {
            lock_btn();
            returnto_island1_LVL2();
        }
        if (return_island1_LVL3 == 1)
        {
            lock_btn();
            returnto_island1_LVL3();
        }
        if (return_island1_LVL4 == 1)
        {
            lock_btn();
            returnto_island1_LVL4();
        }
        if (return_island1_LVL5 == 1)
        {
            lock_btn();
            returnto_island1_LVL5();
        }

        if (return_island2_LVL1 == 1)
        {
            lock_btn();
            returnto_island2_LVL1();
        }
        if (return_island2_LVL2 == 1)
        {
            lock_btn();
            returnto_island2_LVL2();
        }
        if (return_island2_LVL3 == 1)
        {
            lock_btn();
            returnto_island2_LVL3();
        }
        if (return_island2_LVL4 == 1)
        {
            lock_btn();
            returnto_island2_LVL4();
        }
        if (return_island2_LVL5 == 1)
        {
            lock_btn();
            returnto_island2_LVL5();
        }

        if (return_island3_LVL1 == 1)
        {
            lock_btn();
            returnto_island3_LVL1();
        }
        if (return_island3_LVL2 == 1)
        {
            lock_btn();
            returnto_island3_LVL2();
        }
        if (return_island3_LVL3 == 1)
        {
            lock_btn();
            returnto_island3_LVL3();
        }
        if (return_island3_LVL4 == 1)
        {
            lock_btn();
            returnto_island3_LVL4();
        }
        if (return_island3_LVL5 == 1)
        {
            lock_btn();
            returnto_island3_LVL5();
        }

        if (return_island4_LVL1 == 1)
        {
            lock_btn();
            returnto_island4_LVL1();
        }
        if (return_island4_LVL2 == 1)
        {
            lock_btn();
            returnto_island4_LVL2();
        }
        if (return_island4_LVL3 == 1)
        {
            lock_btn();
            returnto_island4_LVL3();
        }
        if (return_island4_LVL4 == 1)
        {
            lock_btn();
            returnto_island4_LVL4();
        }
        if (return_island4_LVL5 == 1)
        {
            lock_btn();
            returnto_island4_LVL5();
        }

        if (return_island5_LVL1 == 1)
        {
            lock_btn();
            returnto_island5_LVL1();
        }
        if (return_island5_LVL2 == 1)
        {
            lock_btn();
            returnto_island5_LVL2();
        }
        if (return_island5_LVL3 == 1)
        {
            lock_btn();
            returnto_island5_LVL3();
        }
        if (return_island5_LVL4 == 1)
        {
            lock_btn();
            returnto_island5_LVL4();
        }
        if (return_island5_LVL5 == 1)
        {
            lock_btn();
            returnto_island5_LVL5();
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

        PlayerPrefs.SetInt("return_island4_LVL1", 0);
        PlayerPrefs.SetInt("return_island4_LVL2", 0);
        PlayerPrefs.SetInt("return_island4_LVL3", 0);
        PlayerPrefs.SetInt("return_island4_LVL4", 0);
        PlayerPrefs.SetInt("return_island4_LVL5", 0);

        PlayerPrefs.SetInt("return_island5_LVL1", 0);
        PlayerPrefs.SetInt("return_island5_LVL2", 0);
        PlayerPrefs.SetInt("return_island5_LVL3", 0);
        PlayerPrefs.SetInt("return_island5_LVL4", 0);
        PlayerPrefs.SetInt("return_island5_LVL5", 0);


      

    }

    private void Update()
    {
        if (math1 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math1_cam_pos.transform.position, Time.deltaTime * time_speed);
        }
        if (math2 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math2_cam_pos.transform.position, Time.deltaTime * time_speed);
        }
        if (math3 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math3_cam_pos.transform.position, Time.deltaTime * time_speed);
        }
        if (math4 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math4_cam_pos.transform.position, Time.deltaTime * time_speed);
        }
        if (math5 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math5_cam_pos.transform.position, Time.deltaTime * time_speed);
        }

    }

    void lock_btn()
    {
        lock2.SetActive(false);
        lock3.SetActive(false);
        lock4.SetActive(false);
        lock5.SetActive(false);
        mathcoll2.SetActive(false);
        mathcoll3.SetActive(false);
        mathcoll4.SetActive(false);
        mathcoll5.SetActive(false);
        mathcoll1.SetActive(false);
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



        math1 = true;
        mathcoll1.SetActive(false);
        math1BTN.SetActive(false);
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



        math1 = true;
        mathcoll1.SetActive(false);
        math1BTN.SetActive(false);
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



        math1 = true;
        mathcoll1.SetActive(false);
        math1BTN.SetActive(false);
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

        math1 = true;
        mathcoll1.SetActive(false);
        math1BTN.SetActive(false);
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

        math1 = true;
        mathcoll1.SetActive(false);
        math1BTN.SetActive(false);
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



        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
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



        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
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



        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
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



        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
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



        math2 = true;
        mathcoll2.SetActive(false);
        math2BTN.SetActive(false);
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



        math3 = true;
        mathcoll3.SetActive(false);
        math3BTN.SetActive(false);
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



        math3 = true;
        mathcoll3.SetActive(false);
        math3BTN.SetActive(false);
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



        math3 = true;
        mathcoll3.SetActive(false);
        math3BTN.SetActive(false);
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



        math3 = true;
        mathcoll3.SetActive(false);
        math3BTN.SetActive(false);
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



        math3 = true;
        mathcoll3.SetActive(false);
        math3BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay3", 2f);
    }

    public void returnto_island4_LVL1()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island4_LVL1_point.transform.position;
        Vector3 b = anchor4.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math4 = true;
        mathcoll4.SetActive(false);
        math4BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay4", 2f);
    }
    public void returnto_island4_LVL2()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island4_LVL2_point.transform.position;
        Vector3 b = anchor4.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math4 = true;
        mathcoll4.SetActive(false);
        math4BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay4", 2f);
    }
    public void returnto_island4_LVL3()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island4_LVL3_point.transform.position;
        Vector3 b = anchor4.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math4 = true;
        mathcoll4.SetActive(false);
        math4BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay4", 2f);
    }
    public void returnto_island4_LVL4()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island4_LVL4_point.transform.position;
        Vector3 b = anchor4.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math4 = true;
        mathcoll4.SetActive(false);
        math4BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay4", 2f);
    }
    public void returnto_island4_LVL5()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island4_LVL5_point.transform.position;
        Vector3 b = anchor4.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math4 = true;
        mathcoll4.SetActive(false);
        math4BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay4", 2f);
    }

    public void returnto_island5_LVL1()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island5_LVL1_point.transform.position;
        Vector3 b = anchor5.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math5 = true;
        mathcoll5.SetActive(false);
        math5BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay5", 2f);
    }
    public void returnto_island5_LVL2()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island5_LVL2_point.transform.position;
        Vector3 b = anchor5.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math5 = true;
        mathcoll5.SetActive(false);
        math5BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay5", 2f);
    }
    public void returnto_island5_LVL3()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island5_LVL3_point.transform.position;
        Vector3 b = anchor5.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math5 = true;
        mathcoll5.SetActive(false);
        math5BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay5", 2f);
    }
    public void returnto_island5_LVL4()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island5_LVL4_point.transform.position;
        Vector3 b = anchor5.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math5 = true;
        mathcoll5.SetActive(false);
        math5BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay5", 2f);
    }
    public void returnto_island5_LVL5()
    {

        character.SetActive(true);
        CharOnBoat.SetActive(false);

        boat.GetComponent<NavMeshAgent>().enabled = false;
        character.GetComponent<NavMeshAgent>().enabled = false;
        Vector3 a = island5_LVL5_point.transform.position;
        Vector3 b = anchor5.transform.position;
        boat.transform.position = b;
        character.transform.position = a;
        boat.GetComponent<NavMeshAgent>().enabled = true;
        character.GetComponent<NavMeshAgent>().enabled = true;



        math5 = true;
        mathcoll5.SetActive(false);
        math5BTN.SetActive(false);
        backtomap.SetActive(true);

        BacktoWorldMap.SetActive(false);
        (boat.GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        Invoke("delay5", 2f);
    }

    //----------------------------------------------------------------------------------------------
    private void delay1()
    {
        math1 = false;
    }
    private void delay2()
    {
        math2 = false;
    }
    private void delay3()
    {
        math3 = false;
    }
    private void delay4()
    {
        math4 = false;
    }
    private void delay5()
    {
        math5 = false;
    }
}
