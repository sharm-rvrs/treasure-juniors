using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Scene_Manual : MonoBehaviour
{
    [SerializeField] private string Scene_Name;
   public void Load_Scene()
    {
        Invoke("wawa", 3);
    }

    void wawa()
    {
        SceneManager.LoadScene(Scene_Name);
    }
}
