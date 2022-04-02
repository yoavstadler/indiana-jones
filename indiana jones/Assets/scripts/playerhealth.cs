using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour
{
    public int health = 10;
    public Text healthtext;
    public GameObject losingCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(GameObject.Find("PlayerCapsule"));
            losingCanvas.SetActive(true);

        }

        healthtext.text = "health:" + health.ToString();
    }
}
