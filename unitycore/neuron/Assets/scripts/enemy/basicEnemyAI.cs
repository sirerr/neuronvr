using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemyAI : MonoBehaviour {

    public float speed = 3;
    public float afterHitWaitTime = 5;
    private Transform pointofInterest;
    public float finalDis = 0;

    private Vector3 startPos;
    public int hits = 0;
    public int hitLimit = 5;
    public bool gotHit = false;

    void Awake()
    {
        pointofInterest = GameObject.FindGameObjectWithTag("zeropoint").transform;
        startPos = transform.position;
    }	
	// Update is called once per frame
	void Update () {

        if (!gotHit)
        {
            float dis = Vector3.Distance(transform.position, pointofInterest.position);
            if (dis>finalDis)
            {
                transform.position = Vector3.MoveTowards(transform.position, pointofInterest.position, speed * Time.deltaTime);
            }

        }

	}

    public void OnCollisionEnter(Collision touch)
    {
        if (touch.transform.CompareTag("tool"))
        {
            gotHit = true;
            hits++;
            if (hits >= hitLimit)
            {
                transform.position = startPos;
                hits = 0;
                StartCoroutine(sleep());
            }
            else
            {
                StartCoroutine(sleep());
            }

        }
    }

    IEnumerator sleep()
    {
        yield return new WaitForSeconds(afterHitWaitTime);
        gotHit = false;
   
    }

}
