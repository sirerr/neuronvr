using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum weapon {shooter,sword};

public class basicweapon : MonoBehaviour {

	//emitter end
	public GameObject emitter;
	public GameObject popperobj;

    //sword part
    public Collider col;
    public GameObject swordpart;

	//steam code
	SteamVR_TrackedObject trackedobj;
	SteamVR_Controller.Device deviceobj;

	//attack paramaters
	public float attackSpeed =3f;

    //weapon type
    public weapon wChoice;
    

	void Awake()
	{
        col = GetComponent<Collider>();
		trackedobj = transform.parent.GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate()
	{
		deviceobj = SteamVR_Controller.Input((int)trackedobj.index);

        switch (wChoice)
        {
            case weapon.shooter:
                basicShoot();
                break;
            case weapon.sword:
                basicSword();
                break;
        }


	}

    public void basicShoot()
    {
        if (col.enabled)
        {
            col.enabled = false;
            swordpart.SetActive(false);
        }

        if (deviceobj.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            GameObject attack;
            attack = Instantiate(popperobj, emitter.transform.position, emitter.transform.rotation) as GameObject;
            attack.GetComponent<basicprojectile>().speed = attackSpeed;
        }

    }

    public void basicSword()
    {
        if (!col.enabled)
        {
            col.enabled = true;
            swordpart.SetActive(true);
        }

    }




}
