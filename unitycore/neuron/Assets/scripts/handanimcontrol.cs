using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class handanimcontrol : MonoBehaviour {

	SteamVR_TrackedObject trackedobj;
	SteamVR_Controller.Device device;
	//hand object
	public GameObject handobj;
	//animator controller
	private Animator handanimator;
	// Use this for initialization
	void Awake () {
		trackedobj = GetComponent<SteamVR_TrackedObject> ();
		handobj = transform.GetChild (1).gameObject;
		handanimator = handobj.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		device = SteamVR_Controller.Input((int)trackedobj.index);

		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) 
		{
			handanimator.SetTrigger("hold");
		}
		if (device.GetPressUp (SteamVR_Controller.ButtonMask.Grip)) 
		{
			handanimator.ResetTrigger("hold");
			handanimator.SetTrigger("unhold");
		}

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			handanimator.SetTrigger("hold");
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			handanimator.ResetTrigger("hold");
			handanimator.SetTrigger("unhold");
			handanimator.ResetTrigger("unhold");
		}

	}
}
