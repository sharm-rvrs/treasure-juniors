using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlvl : MonoBehaviour
{
   
    public void Starttry()
    {
        Invoke("Callthis", .2f);
    }

    void Callthis()
    {
        string a = PlayerPrefs.GetString("loadscene");
        SceneManager.LoadScene(a);
    }
}
