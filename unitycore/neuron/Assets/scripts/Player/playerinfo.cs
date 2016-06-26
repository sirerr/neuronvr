using UnityEngine;
using System.Collections;

public class playerinfo : MonoBehaviour {

	//reference the area manager
	public testareamanager testareamanref;
	//gather info about player

	public GameObject playehead;
	public GameObject controllerobj1;
	public GameObject controllerobj2;

	public Transform playerheight;
	public Transform controller1;
	public Transform controller2;


	void Awake()
	{
		
	}



	// Use this for initialization
	void Start () {
		testareamanref = GetComponent<testareamanager> ();

		playehead = testareamanref.camerarig.transform.GetChild (2).gameObject;
		controllerobj1 = testareamanref.camerarig.transform.GetChild (0).gameObject;
		controllerobj2 = testareamanref.camerarig.transform.GetChild (1).gameObject;

		playerheight = playehead.transform;
		controller1 = controllerobj1.transform;
		controller2 = controllerobj2.transform;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
