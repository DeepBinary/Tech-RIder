using System.Collections;
using System.Collections.Generic;
using CodeMonkey.Utils;
using CodeMonkey;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	#region Variables
	// Movement
	[Header("Movement")]
	public float speed = 20f;
	public float rotationSpeed = 2f;
	public float DashForce;

	[Space(15f)]
	public Vector2 Jumpforce;
	[HideInInspector] public bool Dash = false;
	[HideInInspector] public bool ismoveing = true;
	[HideInInspector] public bool isGrounded = false;
	[HideInInspector] public bool moveback = false;
	[HideInInspector] public bool move = false;
	[HideInInspector] public bool Jump = false;
	[HideInInspector] public bool move_Right_side = false;
	[HideInInspector] public bool move_left_side = false;					

	// DeepBack
	private Rigidbody2D rb;
	private PolygonCollider2D polygoncollider;

	// post processing
	[Header("Post Processing")]
	public Camera GameCamera;

	// SpecialFX
	[Header("SpeicalFX")]
	public GameObject jumpVFX;
	public GameObject DashVFX;
	#endregion

	Vector2 mousepos;
	private void Update()
	{
		if (ismoveing == true)
		{
			if (Input.GetMouseButtonDown(1))
            {
				DashPlayer();
            }

			// W key
			if (Input.GetKeyDown(KeyCode.W))
			{
				move = true;
			}
			if (Input.GetKeyUp(KeyCode.W))
			{
				move = false;
			}


			// S key
			if (Input.GetKeyDown(KeyCode.S))
			{
				moveback = true;
			}
			if (Input.GetKeyUp(KeyCode.S))
			{
				moveback = false;
			}


			// A key
			if (Input.GetKeyDown(KeyCode.A))
			{
				move_left_side = true;
			}

			if (Input.GetKeyUp(KeyCode.A))
			{
				move_left_side = false;
			}


			// D key
			if (Input.GetKeyDown(KeyCode.D))
			{
				move_Right_side = true;
			}

			if (Input.GetKeyUp(KeyCode.D))
			{
				move_Right_side = false;
			}


			// space Key
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Jump = true;
			}

			if (Input.GetKeyUp(KeyCode.Space))
			{
				Jump = false;
			}
		}
	}

	private void FixedUpdate()
	{


		if (Jump == true)
		{
			Instantiate(jumpVFX, transform.position, transform.rotation);
			rb.velocity = Jumpforce;
			Jump = false;
		}


		if (move == true)
		{
			if (isGrounded)
			{
				rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
			}
		}

		if (moveback == true)
		{
			if (isGrounded)
			{
				rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f * -1f, ForceMode2D.Force);
			}
		}

		if (move_Right_side == true)
		{
			if (!isGrounded)
			{
				rb.AddTorque(-rotationSpeed);
				rb.AddForce(new Vector2(speed, 0));
			}
		}

		if (move_left_side == true)
		{
			if (!isGrounded)
			{
				rb.AddTorque(rotationSpeed);
				rb.AddForce(new Vector2(-speed, 0));
			}
		}

	}

	private void OnCollisionEnter2D()
	{
		transform.rotation = transform.rotation;
		isGrounded = true;
	}

	private void OnCollisionExit2D()
	{
		isGrounded = false;
	}

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		Destroy(polygoncollider);
		polygoncollider = GetComponent<PolygonCollider2D>();
		gameObject.AddComponent<PolygonCollider2D>();
	}

	public void DashPlayer()
    {
		Dash = true;	
		Debug.Log("Right Click");
		Instantiate(DashVFX, transform.position, Quaternion.identity);
		rb.AddForce(transform.right * DashForce * Time.deltaTime * 100f, ForceMode2D.Force);
		Dash = false;
	}
}
