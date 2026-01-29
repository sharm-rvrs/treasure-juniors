using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class worldmap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void To_Science()
    {
        SceneManager.LoadScene("Science_Map");

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

    public void To_Math()
    {
        SceneManager.LoadScene("Math_Map");

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

    public void To_World_Map()
    {
        SceneManager.LoadScene("World_Map");
    }

    public void To_Main_Menu()
    {


        PlayerPrefs.SetInt("Player_is", PlayerPrefs.GetInt("account_is"));
        PlayerPrefs.SetInt("return_from_map",1);
        SceneManager.LoadScene("Main_Menu");
    }
}
