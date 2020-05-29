using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public float time;
    public TMPro.TextMeshProUGUI text;

    void Start()
    {
        time = 60;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            Debug.Log("Quit");
            SceneManager.LoadScene("EndMenu");
        }
        string str = "Time: " + (int)time;
        text.SetText(str);
    }
}
