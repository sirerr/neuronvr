using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class usercontrolnovive : MonoBehaviour {

	public MouseLook mouselookref;
	public GameObject toolobj;

	private Vector3 toolstartloc;
	private Transform toolcurrenttransform;
	private Vector3 toolcurrentpos;

	public float mousex =0;
	public float mousey =0;

	public float speed =0;
	public float wheelfloat=0;

	void Awake()
	{
		mouselookref = GetComponent<MouseLook>();
		mouselookref.enabled = false;
		toolstartloc = toolobj.transform.position;

	


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//controller movement
//		toolcurrenttransform = toolobj.transform;
//		toolcurrentpos = toolcurrenttransform.position;
//
//		mousex = Input.GetAxis("Mouse X");
//		mousey = Input.GetAxis("Mouse Y");
//
//		if((mousex<1f && mousex>-1f) && (mousey<1f && mousey > -1f) && !Input.GetMouseButton(1))
//		{
//			toolcurrentpos.x = toolcurrenttransform.position.x +mousex * Time.deltaTime * speed;
//			toolcurrentpos.y = toolcurrenttransform.position.y +mousey * Time.deltaTime *speed;
//			toolcurrentpos.z = toolcurrenttransform.position.z;
//			toolcurrenttransform.position = toolcurrentpos;
//
//		wheelfloat = Input.GetAxis("Mouse ScrollWheel");
//		wheelfloat = wheelfloat *10f;
//
//		if(wheelfloat<2f)
//		{
//			toolcurrentpos.z = transform.position.z + wheelfloat;
//			toolcurrenttransform.position = toolcurrentpos;
//		}
//
//		}
//controller movment end


		if(Input.GetMouseButton(1))
		{
			mouselookref.enabled = true;
		
		}
		else
		{
			mouselookref.enabled = false;

		}

	}
}
