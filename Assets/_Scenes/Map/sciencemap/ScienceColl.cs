using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ScienceColl : MonoBehaviour
{

    public GameObject science1_cam_pos;
    public GameObject science2_cam_pos;
    public GameObject science3_cam_pos;

    public GameObject science_cam_topview;

    public GameObject Maincamera;

    public float time_speed;
    bool science1 = false;
    bool science2 = false;
    bool science3 = false;

    bool sciencemap = false;

    public GameObject science1BTN;
    public GameObject science2BTN;
    public GameObject science3BTN;

    public GameObject backtomap;

    public GameObject sciencecoll1;
    public GameObject sciencecoll2;
    public GameObject sciencecoll3;

    public GameObject BacktoWorldMap;

    public NavMeshAgent Boat;
    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject anchor3;
    
    public GameObject Character;
    public GameObject CharOnBoat;


    [Header("chest")]
    [SerializeField] private GameObject first_chest_island2;
    [SerializeField] private GameObject first_chest_island3;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (science1 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science1_cam_pos.transform.position, Time.deltaTime * time_speed);
            sciencecoll1.SetActive(false);
            science1BTN.SetActive(false);
            backtomap.SetActive(true);
            sciencemap = false;
            BacktoWorldMap.SetActive(false);

            anchor1.SetActive(true);
            Vector3 a = anchor1.transform.position;
            Boat.SetDestination(a);
        }
        if (science2 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science2_cam_pos.transform.position, Time.deltaTime * time_speed);
            sciencecoll2.SetActive(false);
            science2BTN.SetActive(false);
            backtomap.SetActive(true);
            sciencemap = false;
            BacktoWorldMap.SetActive(false);

            anchor2.SetActive(true);
            Vector3 a = anchor2.transform.position;
            Boat.SetDestination(a);
        }
        if (science3 == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science3_cam_pos.transform.position, Time.deltaTime * time_speed);
            sciencecoll3.SetActive(false);
            science3BTN.SetActive(false);
            backtomap.SetActive(true);
            sciencemap = false;
            BacktoWorldMap.SetActive(false);

            anchor3.SetActive(true);
            Vector3 a = anchor3.transform.position;
            Boat.SetDestination(a);
        }

        if (sciencemap == true)
        {
            Maincamera.transform.position = Vector3.Lerp(Maincamera.transform.position, science_cam_topview.transform.position, Time.deltaTime * time_speed);

            sciencecoll1.SetActive(true);
            

            if (first_chest_island2.activeInHierarchy == true)
            {

                sciencecoll2.SetActive(true);

            }

            if (first_chest_island3.activeInHierarchy == true)
            {
                sciencecoll3.SetActive(true);

            }

           



            BacktoWorldMap.SetActive(true);

        }

    }

    public void backtoworldmap()
    {
        SceneManager.LoadScene("World_Map");
    }
    public void math1camera()
    {

        science1 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;

    }
    public void math2camera()
    {

        science2 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;

    }
    public void math3camera()
    {

        science3 = true;
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = false;

    }


    public void backtomaps()
    {
        science1 = false;
        science2 = false;
        science3 = false;

        sciencemap = true;
        backtomap.SetActive(false);
        (GameObject.Find("Boat_Map").GetComponent("ClickToMove") as MonoBehaviour).enabled = true;

        Character.SetActive(false);
        CharOnBoat.SetActive(true);

        anchor1.SetActive(false);
        anchor2.SetActive(false);
        anchor3.SetActive(false);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("science1"))
        {
            science1BTN.SetActive(true);
        }
        if (other.tag == ("science2"))
        {
            science2BTN.SetActive(true);
        }
        if (other.tag == ("science3"))
        {
            science3BTN.SetActive(true);
        }




    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("science1"))
        {
            science1BTN.SetActive(false);
        }
        if (other.tag == ("science2"))
        {
            science2BTN.SetActive(false);
        }
        if (other.tag == ("science3"))
        {
            science3BTN.SetActive(false);
        }




    }
}
