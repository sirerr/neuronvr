using UnityEngine;
using System.Collections;
using Valve.VR;
using System.Collections.Generic;


public class areamanager : MonoBehaviour {

    public List<basicLock> locks = new List<basicLock>();
    public int lockCount = 0;
    
	void Awake()
	{

	}

	// Update is called once per frame
	void Update () {

        if (lockCount == locks.Count)
        {
           
        }

	}


}
