using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expanding_box : MonoBehaviour
{
    public bool powerTime;
    Renderer meshrenderer;
    private Vector3 size = new Vector3(0.01f,0.01f,0.01f);

    private void Start()
    {
        
    }
    void Update()
    {

        if (powerTime)
        {
            transform.localScale = transform.localScale + size;
            if (transform.localScale.x >= 4)
            {
                powerTime = false;
            }
           
        }
        else
        {
            transform.localScale = transform.localScale - size;
            if (transform.localScale.x <= 1)
            {
                powerTime = true;
            }
        }
    }
}
  
