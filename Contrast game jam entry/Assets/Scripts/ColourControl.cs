using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColourControl : MonoBehaviour
{
    public Renderer render;
    public bool isWhite = true;
    public Vector3 StartPos;

    private void Start()
    {
        render = GetComponent<Renderer>();
        render.material.SetColor("_Color", Color.white);
        StartPos = transform.position; 
    }
    // Update is called once per frame

    private void Update()
    {
        colourChange();
        Resetlevel();
        QuitGame();
    }
    
   public void colourChange()
   {
        if (Input.GetKeyDown(KeyCode.R)&& isWhite)
        {
            render.material.SetColor("_Color", Color.black);
            isWhite = false;
          //  Debug.Log("capsule is black!");


        }
       
        else if (Input.GetKeyDown(KeyCode.R)&& !isWhite)
        {
            render.material.SetColor("_Color", Color.white);
            isWhite = true;
            //Debug.Log("capsule is white!");
        }
        

    }


    public void Resetlevel()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
    }

    public void QuitGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting...");
        }
    }




}
