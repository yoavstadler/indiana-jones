using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("medkit"))
        {
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.CompareTag("traps"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("trapholders"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("coins"))
        {

            Destroy(collision.gameObject , 0.1f);
        }





    }
}
