using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformlauncher : MonoBehaviour
{
    [SerializeField]
    GameObject Bplat;

    [SerializeField]
    GameObject WPlat;
    GameObject currentPlat;

   [SerializeField] float maxTime = 10.0f;
    float launchTime;

    // Start is called before the first frame update
    void Start()
    {
        launchTime = maxTime;
        currentPlat = Bplat;
    }

    // Update is called once per frame
    void Update()
    {
        launchTime -= Time.deltaTime;
        //if (launchTime == 5.0f)
        //{
        //    Instantiate(Bplat, transform.position, transform.rotation);
        //}
        if (launchTime <=0)
        {
            if(currentPlat == Bplat)
            {
                currentPlat = WPlat;
            }
            else if(currentPlat == WPlat)
            {
                currentPlat = Bplat;
            }

            launchTime = maxTime;
            Instantiate(currentPlat, transform.position, transform.rotation);
        }
        
    }
}
