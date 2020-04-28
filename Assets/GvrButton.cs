using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GvrButton : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GvrClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Invoked");
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            Debug.Log(gvrTimer);
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if(gvrTimer > totalTime)
        {
            Debug.Log("WTF");
            GvrClick.Invoke();
            imgCircle.fillAmount = 0;
            gvrTimer = 0;
        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
