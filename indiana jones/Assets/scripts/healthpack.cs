using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpack : MonoBehaviour
{
    MeshRenderer meshrenderer;
    bool powerTime;
    // Start is called before the first frame update
    private void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerhealth>().health+=2;
        }
    }

    void Update()
    {
        if (powerTime)
        {
            meshrenderer.material.SetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209", meshrenderer.material.GetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209") + 0.01f);
            if (meshrenderer.material.GetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209") >= 5)
                powerTime = false;
        }
        else
        {
            meshrenderer.material.SetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209", meshrenderer.material.GetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209") - 0.01f);
            if (meshrenderer.material.GetFloat("Vector1_c6998551a9a74ecd90bcdc242d3e2209") <= 1)
                powerTime = true;
        }

        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.time) + 6.9f),transform.position.z);


    }
}
