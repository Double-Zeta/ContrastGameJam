using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bPlatTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject bPlatform;

    ColourControl ccontrol;

    private void Start()
    {
        ccontrol = FindObjectOfType<ColourControl>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (ccontrol.isWhite == false)
        {
            Destroy(bPlatform);
        }
    }
}
