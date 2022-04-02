using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapscollision : MonoBehaviour
{
     Renderer meshrenderer;
    public GameObject Player;
    // Start is called before the first frame update
    private void Start()
    {
        meshrenderer = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerhealth>().health--;
           Player.GetComponent<AudioSource>().Play();
            meshrenderer.material.SetFloat("Vector1_d42ab8f80ae04f7e9196fb5ba7649675", meshrenderer.material.GetFloat("Vector1_d42ab8f80ae04f7e9196fb5ba7649675") + 0.5f);
        }
    }
}
