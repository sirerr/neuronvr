using UnityEngine;
using System.Collections;

public class testareamanager : MonoBehaviour {

	public GameObject camerarig;
	public SteamVR_PlayArea playarearef;

	public Vector3 playarealoc1;
	public Vector3 playarealoc2;
	public Vector3 playarealoc3;
	public Vector3 playarealoc4;

	public GameObject wall0;
	public GameObject wall1;
	public GameObject wall2;
	public GameObject wall3;

	void Awake()
	{
		camerarig = GameObject.FindGameObjectWithTag("MainCamera");
//	

	}

	// Use this for initialization
	void Start () {
		playarealoc1 = playarearef.vertices [0];
		playarealoc2 = playarearef.vertices [1];
		playarealoc3 = playarearef.vertices [2];
		playarealoc4 = playarearef.vertices [3];

		wall0.transform.position = playarealoc1;
		wall1.transform.position = playarealoc2;
		wall2.transform.position = playarealoc3;
		wall3.transform.position = playarealoc4;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
