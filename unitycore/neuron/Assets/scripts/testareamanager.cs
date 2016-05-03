using UnityEngine;
using System.Collections;

public class testareamanager : MonoBehaviour {

	public GameObject camerarig;
	public SteamVR_PlayArea playarearef;

	void Awake()
	{
		camerarig = GameObject.FindGameObjectWithTag("MainCamera");
		playarearef = camerarig.GetComponent<SteamVR_PlayArea> ();

	}

	// Use this for initialization
	void Start () {
		playarearef = camerarig.GetComponent<SteamVR_PlayArea> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
