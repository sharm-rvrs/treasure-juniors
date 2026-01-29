using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTN_Function_GamePlay : MonoBehaviour
{
    [SerializeField] private GameObject Pause_Panel;
    [SerializeField] private GameObject Submit_Confirm_Panel;
    [SerializeField] private GameObject blurred;
    [SerializeField] private string Subject_Topic_Stage_Level;



    public void Pause()
    {
        Pause_Panel.SetActive(true);
        blurred.SetActive(true);
    }

    public void Resume_to_gameplay()
    {
        Pause_Panel.SetActive(false);
        blurred.SetActive(false);
    }

    public void Confirm_Submit_Panel()
    {
        Submit_Confirm_Panel.SetActive(true);
        blurred.SetActive(true);
    }

    public void Confirm_No_Submit_Panel()
    {
        Submit_Confirm_Panel.SetActive(false);
        blurred.SetActive(false);
    }

    public void Restart_Gameplay()
    {
        SceneManager.LoadScene(Subject_Topic_Stage_Level);
    }

}
