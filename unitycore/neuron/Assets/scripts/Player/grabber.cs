using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabber : MonoBehaviour {

    protected canGrab currentgrabed;
    protected canGrab heldItemgrabbed;

    protected bool shouldDrop;
    public Rigidbody holdobj;


    public virtual void FixedUpdate()
    {
        currentgrabed = null;
    }

    void OnTriggerStay(Collider col)
    {
        Rigidbody rigid = col.GetComponentInParent<Rigidbody>();
        if (rigid != null)
        {
            canGrab newCanGrab = rigid.GetComponent<canGrab>();
            if (newCanGrab != null && newCanGrab.canInteract)
            {
                currentgrabed = newCanGrab;
                                
            }
        }

    }

    void OnTriggerExit(Collider col)
    {
        Rigidbody rigid = col.GetComponentInParent<Rigidbody>();
        if (rigid != null)
        {
            canGrab grabee = rigid.GetComponent<canGrab>();
             }
    }

    public void drop()
    {
        shouldDrop = true;
    }

    public virtual void doDrop()
    {
        heldItemgrabbed.letgo(transform);
        heldItemgrabbed = null;
    }

}
