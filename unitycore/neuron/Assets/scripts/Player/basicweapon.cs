using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum weapon {shooter,sword};

public enum ViveButton
{
    Trigger,
    Grip,
    TrackPress,
    Menu
}

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


    public ViveButton vivebutton = ViveButton.Trigger;


    void Awake()
	{
        col = GetComponent<Collider>();
		trackedobj = transform.parent.GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate()
	{
		deviceobj = SteamVR_Controller.Input((int)trackedobj.index);

        ulong triggerButton = SteamVR_Controller.ButtonMask.Trigger;

        switch (vivebutton)
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


        switch (wChoice)
        {
            case weapon.shooter:
                basicShoot(triggerButton);
                break;
            case weapon.sword:
                basicSword();
                break;
        }


	}

    public void basicShoot(ulong button)
    {
        if (col.enabled)
        {
            col.enabled = false;
            swordpart.SetActive(false);
        }

        if (deviceobj.GetPressDown(button))
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
