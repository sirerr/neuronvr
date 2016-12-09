using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicCollector : grabber {

    public float energyAmount =0;

    //steam code
    SteamVR_TrackedObject trackedobj;
    SteamVR_Controller.Device deviceobj;

    public ViveButton viveinput = ViveButton.Trigger;

    void Awake()
    {
        trackedobj = transform.parent.GetComponent<SteamVR_TrackedObject>();
    }

    public override void FixedUpdate()
    {

        if (shouldDrop)
        {
            doDrop();
            shouldDrop = false;
        }

        deviceobj = SteamVR_Controller.Input((int)trackedobj.index);

        ulong triggerButton = SteamVR_Controller.ButtonMask.Trigger;

        switch (viveinput)
        {
            case ViveButton.Trigger:
                triggerButton = SteamVR_Controller.ButtonMask.Trigger;
                break;
            case ViveButton.Grip:
                triggerButton = SteamVR_Controller.ButtonMask.Grip;
                break;
            case ViveButton.TrackPress:
                triggerButton = SteamVR_Controller.ButtonMask.Touchpad;
                break;
            case ViveButton.Menu:
                triggerButton = SteamVR_Controller.ButtonMask.ApplicationMenu;
                break;
        }

        if (heldItemgrabbed == null && currentgrabed != null)
        {
            if (deviceobj.GetPressDown(triggerButton) && currentgrabed.canInteract)
            {
          // start here tomrrow  //    currentgrabed.grabbed()
            }


        }

        if (heldItemgrabbed != null)
        {
            heldItemgrabbed.holding(holdobj.transform);
        }

        base.FixedUpdate();
    }

    public override void doDrop()
    {
        base.doDrop();
    }


}
