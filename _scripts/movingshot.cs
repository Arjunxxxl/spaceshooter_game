using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingshot : MonoBehaviour {

	public float speed;
	public Rigidbody rb;

	void Start ()
	{
		speed = 20;
		rb.velocity = transform.forward * speed;
	}
}
