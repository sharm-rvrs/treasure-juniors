using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class To_Story_Science : MonoBehaviour
{
    // Start is called before the first frame update
   public void to_science()
    {
        PlayerPrefs.SetInt("island_story", 1);
    }
}
