using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRaycastTeleport : MonoBehaviour {


    SteamVR_TrackedObject[] trackedobj;
    SteamVR_Controller.Device deviceobj;
    public ViveButton viveinput = ViveButton.Trigger;
    public float castLength = 50f;
    public LayerMask lmask;
    private Transform parent;
    public LayerMask areaLayername;
    void Awake()
    {
        trackedobj = transform.GetComponentsInChildren<SteamVR_TrackedObject>();
      
    }

    private void FixedUpdate()
    {
        RaycastHit rHit;
        for (int i = 0; i < trackedobj.Length; i++)
        {
            if (trackedobj[i].gameObject.activeSelf)
            {
                deviceobj = SteamVR_Controller.Input((int)trackedobj[i].index);

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


                if (deviceobj.GetPressDown(triggerButton))
                {
                    print("this is working");
                    var cam = SteamVR_Render.Top().gameObject;
                    //need direction;
                    Ray ray = new Ray(transform.position,cam.transform.forward * castLength);
                   transform.position = ray.GetPoint(castLength);

                }


            }
        }



        

    }
    
}
