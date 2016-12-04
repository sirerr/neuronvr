using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicprojectile : MonoBehaviour {

    public Rigidbody rbody;
    public float speed = 0;
    public float waitTime = 10;

    public void Awake()
    {
        rbody = GetComponent<Rigidbody>();


    }

    public void FixedUpdate()
    {
        rbody.velocity = transform.forward * speed;
        StartCoroutine(death());
    }

    IEnumerator death()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }

}
