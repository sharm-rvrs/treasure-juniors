using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip_button : MonoBehaviour
{
    [SerializeField] private string scene_name;
    [SerializeField] private float Skip_Time;
    [SerializeField] private GameObject Button;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Skip", Skip_Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Skip()
    {
        Button.SetActive(true);
    }

    public void skip_scene()
    {
        SceneManager.LoadScene(scene_name);
    }
}
