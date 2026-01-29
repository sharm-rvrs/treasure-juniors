using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltest : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Chest;
    public GameObject Discription_panel;
    public string scene_lvl;
    public string discription;
    public string lvltext;
    public TextMeshProUGUI Discription_Text;
    public TextMeshProUGUI Title_LVL_Text;
    public GameObject bcktomap;


    private void Start()
    {
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Chest.Play("open");
            Discription_panel.SetActive(true);
            PlayerPrefs.SetString("loadscene", scene_lvl);
            Discription_Text.text = discription;
            Title_LVL_Text.text = lvltext;
            bcktomap.SetActive(false);
            


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Chest.Play("close");
            Discription_panel.SetActive(false);
            bcktomap.SetActive(true);
        }
    }

   
}
