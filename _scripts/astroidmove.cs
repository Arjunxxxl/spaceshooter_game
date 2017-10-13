using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidmove : MonoBehaviour {

	public float speed;
	public Rigidbody rb;

	void Start ()
	{
		speed = -8.0f;
		rb.velocity = transform.forward * speed;
	}
}
