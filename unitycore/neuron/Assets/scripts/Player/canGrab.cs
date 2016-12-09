using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canGrab : MonoBehaviour {

    public bool canInteract = true;
    public bool isgrabbed = false;

    public virtual void grabbed()
    {
        isgrabbed = true;
    }

    public virtual void holding(Transform bar)
    {

    }

    public virtual void letgo(Transform item)
    {

    }

}
