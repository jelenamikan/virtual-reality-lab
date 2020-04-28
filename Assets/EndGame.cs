using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Time.time > 120)
        {
            Debug.Log("Quit");
            SceneManager.LoadScene("EndMenu");
        } 
    }
}
