using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    private int nextLevel;
    
    // Start is called before the first frame update
   public void Start()
    {
        
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        loadLevel();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    
}
