using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject pick_axe;
    public GameObject hand;
    bool inHand = false;
    Vector3 axePos;
    Quaternion axeRot;

    // Start is called before the first frame update
    void Start()
    {
        axePos = pick_axe.transform.position;
        axeRot = pick_axe.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHand)
            {
                pick_axe.transform.SetParent(hand.transform);
                pick_axe.transform.localPosition = new Vector3(0.5f, -7.5f, 3.78f);
                pick_axe.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);
                //pick_axe.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                inHand = true;
            } else
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                pick_axe.transform.SetParent(null);
                pick_axe.transform.localPosition = axePos;
                pick_axe.transform.localRotation = axeRot;
                inHand = false;
            }
        }
    }
}
