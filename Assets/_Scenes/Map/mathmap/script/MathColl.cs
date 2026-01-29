using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MathColl : MonoBehaviour
{
    [Header("Lock image btn")]
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private GameObject lock4;
    [SerializeField] private GameObject lock5;

    public GameObject math1_cam_pos;
    public GameObject math2_cam_pos;
    public GameObject math3_cam_pos;
    public GameObject math4_cam_pos;
    public GameObject math5_cam_pos;

    public GameObject math_cam_topview;

    public GameObject Maincamera;

    public float time_speed;
    bool math1 = false;
    bool math2 = false;
    bool math3 = false;
    bool math4 = false;
    bool math5 = false;
    bool mathmap = false;

    public GameObject math1BTN;
    public GameObject math2BTN;
    public GameObject math3BTN;
    public GameObject math4BTN;
    public GameObject math5BTN;
    public GameObject backtomap;

    public GameObject mathcoll1;
    public GameObject mathcoll2;
    public GameObject mathcoll3;
    public GameObject mathcoll4;
    public GameObject mathcoll5;

    public GameObject BacktoWorldMap;

    public NavMeshAgent Boat;
    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject anchor3;
    public GameObject anchor4;
    public GameObject anchor5;
    public GameObject Character;
    public GameObject CharOnBoat;

    [Header("chest")]
    [SerializeField] private GameObject first_chest_island2;
    [SerializeField] private GameObject first_chest_island3;
    [SerializeField] private GameObject first_chest_island4;
    [SerializeField] private GameObject first_chest_island5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (math1 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math1_cam_pos.transform.position, Time.deltaTime * time_speed);
            mathcoll1.SetActive(false);
            math1BTN.SetActive(false);
            
            mathmap = false;
            BacktoWorldMap.SetActive(false);

            
            anchor1.SetActive(true);
            Vector3 a = anchor1.transform.position;
            Boat.SetDestination(a);
            
        }
        if (math2 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math2_cam_pos.transform.position, Time.deltaTime * time_speed);
            mathcoll2.SetActive(false);
            math2BTN.SetActive(false);
            
            mathmap = false;
            BacktoWorldMap.SetActive(false);

            
            anchor2.SetActive(true);
            Vector3 a = anchor2.transform.position;
            Boat.SetDestination(a);
            
        }
        if (math3 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math3_cam_pos.transform.position, Time.deltaTime * time_speed);
            mathcoll3.SetActive(false);
            math3BTN.SetActive(false);
            
            mathmap = false;
            BacktoWorldMap.SetActive(false);

            
            anchor3.SetActive(true);
            Vector3 a = anchor3.transform.position;
            Boat.SetDestination(a);
            
        }
        if (math4 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math4_cam_pos.transform.position, Time.deltaTime * time_speed);
            mathcoll4.SetActive(false);
            math4BTN.SetActive(false);
            
            mathmap = false;
            BacktoWorldMap.SetActive(false);

            
            anchor4.SetActive(true);
            Vector3 a = anchor4.transform.position;
            Boat.SetDestination(a);
            
        }
        if (math5 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math5_cam_pos.transform.position, Time.deltaTime * time_speed);
            mathcoll5.SetActive(false);
            math5BTN.SetActive(false);
            
            mathmap = false;
            BacktoWorldMap.SetActive(false);

            
            anchor5.SetActive(true);
            Vector3 a = anchor5.transform.position;
            Boat.SetDestination(a);
            
        }
        if (mathmap == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, math_cam_topview.transform.position, Time.deltaTime * time_speed);

            //if (first_chest_island2.activeInHierarchy == true)
            //{
            //    lock2.SetActive(false);
            //   mathcoll2.SetActive(true);
            //}
            //else
            //{
            //    mathcoll2.SetActive(false);
            //}

            //if (first_chest_island3.activeInHierarchy == true)
            //{
            //    lock3.SetActive(false);

            //    mathcoll3.SetActive(true);
            //}
            //else
            //{
            //    mathcoll3.SetActive(false);
            //}

            //if (first_chest_island4.activeInHierarchy == true)
            //{
            //    lock4.SetActive(false);

            //    mathcoll4.SetActive(true);
            //}
            //else
            //{
            //    mathcoll4.SetActive(false);
            //}

            //if (first_chest_island5.activeInHierarchy == true)
            //{
            //    lock5.SetActive(false);

            //    mathcoll5.SetActive(true);
            //}
            //else
            //{
            //    mathcoll5.SetActive(false);
            //}

            //if (first_chest_island2.activeInHierarchy == true)
            //{

            //    mathcoll2.SetActive(true);


            //}

            //if (first_chest_island3.activeInHierarchy == true)
            //{
            //    mathcoll3.SetActive(true);

            //}

            //if (first_chest_island4.activeInHierarchy == true)
            //{

            //    mathcoll4.SetActive(true);
            //}

            //if (first_chest_island5.activeInHierarchy == true)
            //{
            //    mathcoll5.SetActive(true);

            //}

            BacktoWorldMap.SetActive(true);
            

        }

    }
    public void backtoworldmap()
    {
        SceneManager.LoadScene("World_Map");
        backtomap.SetActive(false);
    }

    public void math1camera()
    {

        math1 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        backtomap.SetActive(true);

    }
    public void math2camera()
    {

        math2 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        backtomap.SetActive(true);

    }
    public void math3camera()
    {

        math3 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        backtomap.SetActive(true);

    }
    public void math4camera()
    {

        math4 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        backtomap.SetActive(true);

    }
    public void math5camera()
    {

        math5 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;
        backtomap.SetActive(true);

    }

    public void backtomaps()
    {
        math1 = false;
        math2 = false;
        math3 = false;
        math4 = false;
        math5 = false;
        mathmap = true;
        backtomap.SetActive(false);
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = true;

        Character.SetActive(false);
        CharOnBoat.SetActive(true);

        anchor1.SetActive(false);
        anchor2.SetActive(false);
        anchor3.SetActive(false);
        anchor4.SetActive(false);
        anchor5.SetActive(false);


        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("math1"))
        {
             math1BTN.SetActive(true);
        }
        if (other.tag == ("math2"))
        {
            math2BTN.SetActive(true);
        }
        if (other.tag == ("math3"))
        {
            math3BTN.SetActive(true);
        }
        if (other.tag == ("math4"))
        {
            math4BTN.SetActive(true);
        }
        if (other.tag == ("math5"))
        {
            math5BTN.SetActive(true);
        }



    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("math1"))
        {
            math1BTN.SetActive(false);
        }
        if (other.tag == ("math2"))
        {
            math2BTN.SetActive(false);
        }
        if (other.tag == ("math3"))
        {
            math3BTN.SetActive(false);
        }
        if (other.tag == ("math4"))
        {
            math4BTN.SetActive(false);
        }
        if (other.tag == ("math5"))
        {
            math5BTN.SetActive(false);
        }


    }
  
}


