using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicPosEnergyAction : canGrab {

    private Rigidbody rbody;

    public bool isholding = false;
    private Vector3 collectorLoc;

    

    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }

    public override void grabbed()
    {
        if (canInteract)
        {
            base.grabbed();
            transform.parent = null;
            rbody.isKinematic = false;

            isholding = true;
            rbody.useGravity = false;
            rbody.maxAngularVelocity = 100f;
        }
                
    }

    public override void holding(Transform handle)
    {
        if (isholding)
        {
            collectorLoc = handle.position;
            Vector3 objRelativePos = collectorLoc - transform.position;

        }

    }

    public override void letgo(Transform item)
    {
        if (isholding)
        {
            isholding = false;   
        }
    }


}
