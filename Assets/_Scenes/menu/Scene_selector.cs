using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_selector : MonoBehaviour
{
    [SerializeField] private string Scena_Name;
   public void scene()
    {
        SceneManager.LoadScene(Scena_Name);
    }
}
