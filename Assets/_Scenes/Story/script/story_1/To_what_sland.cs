using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_what_sland : MonoBehaviour
{
    [SerializeField] private string math_return_islandX_LVLX;
    [SerializeField] private string science_return_islandX_LVLX;

    int a;
    private void Start()
    {
        a = PlayerPrefs.GetInt("island_story");
    }

    public void Return_island()
    {
        Invoke("return_islands",3);
    }

    void return_islands()
    {
        if(a == 0)
        {
            PlayerPrefs.SetInt(math_return_islandX_LVLX, 1);
            
            SceneManager.LoadScene("Math_Map");
            
        }
        else
        {
            PlayerPrefs.SetInt("island_story",1);
            PlayerPrefs.SetInt(science_return_islandX_LVLX, 1);
            PlayerPrefs.SetInt("island_story",0);
            SceneManager.LoadScene("Science_Map");
        }
        
    }
}
