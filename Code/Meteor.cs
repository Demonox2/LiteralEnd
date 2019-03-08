using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
	public float moveSpeed = 0.01f;

	void Update()
	{
		transform.Translate(new Vector3(0, -moveSpeed, 0));
	}
}
