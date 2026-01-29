using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTN_effect_sound : MonoBehaviour
{
    
    public void SOUND_EFFECT()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
