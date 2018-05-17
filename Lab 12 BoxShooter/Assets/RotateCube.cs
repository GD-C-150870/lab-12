using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

    public float SpinSPeed = 180f;
    public string Choice;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Choice == "Up")
        {
            gameObject.transform.Rotate(Vector3.up * SpinSPeed * Time.deltaTime);
        }
        if (Choice == "Down")
        {
            gameObject.transform.Rotate(Vector3.down * SpinSPeed * Time.deltaTime);
        }
        if (Choice == "Left")
        {
            gameObject.transform.Rotate(Vector3.left * SpinSPeed * Time.deltaTime);
        }
        if (Choice == "Right")
        {
            gameObject.transform.Rotate(Vector3.right * SpinSPeed * Time.deltaTime);
        }
        if (Choice == "Forward")
        {
            gameObject.transform.Rotate(Vector3.forward * SpinSPeed * Time.deltaTime);
        }
        if (Choice == "Backward")
        {
            gameObject.transform.Rotate(Vector3.back * SpinSPeed * Time.deltaTime);
        }

		
	}
}
