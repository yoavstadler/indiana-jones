using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class releasetrapholder2 : MonoBehaviour
{
    GameObject trapholder1;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(GameObject.Find("bolder holder"));
        }
    }
}
