﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Projectile")
		{
			Destroy(collision.gameObject);
		}
	}
}
