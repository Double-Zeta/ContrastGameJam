using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class FallBound : MonoBehaviour
{
    //[SerializeField]
    //GameObject player;

    private ThirdPersonController TPController;
   
    ColourControl ccontrol;
    public void Start()
    {
       ccontrol = FindObjectOfType<ColourControl>();
        TPController = FindObjectOfType<ThirdPersonController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        TPController.gameObject.SetActive(false);
        TPController.transform.position = ccontrol.StartPos;
        TPController.gameObject.SetActive(true);
        
    }
}
