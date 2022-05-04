using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wPlatTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject wPlatform;
    ColourControl ccontrol;

    private void Start()
    {
        ccontrol = FindObjectOfType<ColourControl>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(ccontrol.isWhite == true)
        {
            Destroy(wPlatform);
        }
    }



}
