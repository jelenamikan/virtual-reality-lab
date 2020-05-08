using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTreasure : MonoBehaviour
{
    //public GameObject textBox;
    int gold;
    public TMPro.TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseGold(int val)
    {
        gold += val;
        string str = "Gold: " + gold;
        text.SetText(str);
    }

    public void destroyObject(string destroyed)
    {
        Destroy(GameObject.Find(destroyed));
    }
}
