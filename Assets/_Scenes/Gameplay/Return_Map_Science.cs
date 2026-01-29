using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_Map_Science : MonoBehaviour
{
    [SerializeField] private string return_islandX_LVLX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void putang_ina()
    {
        PlayerPrefs.SetInt(return_islandX_LVLX, 1);
        SceneManager.LoadScene("Science_Map");
    }
}
