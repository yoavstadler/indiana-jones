using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtrap : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerhealth>().health = 0;
            Debug.Log("boom");
        }
    }
}
