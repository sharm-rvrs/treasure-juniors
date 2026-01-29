using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_To_Main : MonoBehaviour
{
    public void To_Main_Menu()
    {


        PlayerPrefs.SetInt("Player_is", PlayerPrefs.GetInt("account_is"));
        PlayerPrefs.SetInt("return_from_map", 1);
        SceneManager.LoadScene("Main_Menu");
    }
}
