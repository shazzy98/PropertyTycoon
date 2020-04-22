using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dice : MonoBehaviour 
{
    [HideInInspector]
    public float minRollForce;
    public float maxRollForce;
    public int value;
    Rigidbody rb;
    public UnityEvent RollEvent;
    public bool Rolling;

    void Awake () 
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Rolling == true)
        {
            if (rb.IsSleeping())
            {
                Rolling = false;
                calculateValue();
                RollEvent.Invoke();
            }
        }
	}



    public void AddForceToDice()
    {
        if (!Rolling)
        {
            Rolling = true;
            Vector3 RandomPosition = new Vector3(Random.Range(-0.2f, 0.2f), -1, Random.Range(-0.2f, 0.2f));
            rb.AddExplosionForce(Random.Range(minRollForce, maxRollForce), RandomPosition, -0.5f, 2f);  
        }
    }


    void calculateValue()
    {
        float upDot = Vector3.Dot(Vector3.up, transform.up);
        float rightDot = Vector3.Dot(Vector3.up, transform.right);
        float forwardDot = Vector3.Dot(Vector3.up, transform.forward);

        if (System.Math.Abs(upDot - 1) < 0.1f)
        {
            value = 1;
        }
        if (System.Math.Abs(upDot - -1) < 0.1f)
        {
            value = 6;
        }
        if (System.Math.Abs(rightDot - 1) < 0.1f)
        {
            value = 4;
        }
        if (System.Math.Abs(rightDot - -1) < 0.1f)
        {
            value = 3;
        }
        if (System.Math.Abs(forwardDot - 1) < 0.1f)
        {
            value = 2;
        }
        if (System.Math.Abs(forwardDot - -1) < 0.1f)
        {
            value = 5;
        }
    }




}