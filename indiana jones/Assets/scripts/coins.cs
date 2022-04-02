using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    MeshRenderer meshrenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.time) + 6.9f), transform.position.z);
        transform.rotation = Quaternion.Euler(90, 0, ((transform.rotation.z) +30)* Time.time);
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerpoints>().points++;
        }


    }
}
