using UnityEngine;
using System.Collections;

public class CaptureScript : MonoBehaviour {

    public Transform sphere;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Espeon"))
        {
            Debug.Log("Pokeball Collided.");
            //Makes Espeon disappear
            other.gameObject.SetActive(false);
            //Makes the ball stop (Well it should)
            sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
            sphere.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            sphere = null;
        }
    }
}

