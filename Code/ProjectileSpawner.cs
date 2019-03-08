using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{

	public Transform[] spawnPoints;

	public GameObject Projectile;

	public float DownTime = 1.0f;

	private float SpawnTimer = 2.0f;

	void Update()
	{
		if (Time.time >= SpawnTimer)
		{
			SpawnProjectiles();
			SpawnTimer = Time.time + DownTime;
		}
	}

	void SpawnProjectiles()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(Projectile, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
}
