using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomrotator : MonoBehaviour {
	public float tumble;
	public Rigidbody rb;

	void Start(){
		tumble = 3.0f;
		rb.GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}