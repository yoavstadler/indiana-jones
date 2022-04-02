using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerpoints : MonoBehaviour
{
    public int points;
    public Text pointstext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointstext.text = "score:" + points.ToString();
    }
   
}
