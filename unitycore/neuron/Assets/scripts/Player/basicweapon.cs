using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class basicweapon : MonoBehaviour {

	public List<GameObject> poppers = new List<GameObject>();
	public int poppercount =0;

	//emitter end
	public GameObject emitter;
	public GameObject popperobj;

	//steam code
	SteamVR_TrackedObject trackedobj;
	SteamVR_Controller.Device deviceobj;

	//attack paramaters
	public float attackspeed =3f;

	void Awake()
	{
		poppercount = poppers.Count;
		for (int i = 0; i < poppercount; i++) {
			poppers [i] = popperobj;
		}

		trackedobj = transform.parent.GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate()
	{
		deviceobj = SteamVR_Controller.Input((int)trackedobj.index);

		if(deviceobj.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			GameObject attack;
			attack = Instantiate (popperobj, emitter.transform.position, Quaternion.identity) as GameObject;
			Rigidbody rbody = attack.GetComponent<Rigidbody> ();
			rbody.velocity = emitter.transform.forward * attackspeed;
		}
	}
}
