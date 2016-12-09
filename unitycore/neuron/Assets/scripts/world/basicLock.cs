using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicLock : MonoBehaviour {

    public bool circuitLocked = false;
    public Collider coll;
    private areamanager manref;


    void Awake()
    {
        coll = GetComponent<Collider>();
        manref = GetComponentInParent<areamanager>();
        manref.locks.Add(GetComponent<basicLock>());
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("tool"))
        {
            circuitLocked = true;
            coll.enabled = false;
            manref.lockCount++;
        }
    }

}
