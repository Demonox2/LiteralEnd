using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	public Animator animator;

	public float speed;
	private float moveInput;
	//public float jumpForce; //do i really want a jump
	private Rigidbody2D rb;
	public float health;
	public float MaxHealth = 100;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		health = MaxHealth;
	}

    // Update is called once per frame
    void Update()
    {
		if (health > 0)
		{
			Movement();
		}

		else
		{
			Debug.Log("We died");
			SceneManager.LoadScene(2);
		}
		///else die
    }

	void Movement()
	{
		float moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Projectile")
		{
			health = health - 10;
			Destroy(collision.gameObject);
		}
	}
}
