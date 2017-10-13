using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boldshot : MonoBehaviour {

	public float speed;
	public Rigidbody rb;

	void Start ()
	{
		speed = 20.0f;
		rb.velocity = transform.forward * speed;
	}
}
