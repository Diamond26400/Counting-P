using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //Restart all the scene 

    }

    // Update is called once per frame


    public void Reload()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
