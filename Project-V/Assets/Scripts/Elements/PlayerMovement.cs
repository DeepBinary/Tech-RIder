using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[Header("Movement")]
	public float speed = 20f, rotationSpeed = 2f;

	[Space(15f)]
	public Vector2 Jumpforce;
	[HideInInspector] public bool ismoveing = true, isGrounded = false, RotateTowardsMouse = false;
	[HideInInspector] public bool moveback = false, move = false, Jump = false, move_Right_side = false, move_left_side = false;

	private Rigidbody2D rb;
	private PolygonCollider2D polygoncollider;	
	public Camera GameCamera;

	[Header("SpeicalFX")]
	public GameObject jumpVFX;
	Vector2 mousepos;
	private void Update()
	{
		if (ismoveing == true)
		{

			if (Input.GetKey(KeyCode.LeftShift))
            {
				RotateTowardsMouse = true;
            }
			if (Input.GetKeyUp(KeyCode.LeftShift))
            {
				RotateTowardsMouse = false;
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
		if (RotateTowardsMouse == true)
        {
			Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = Input.mousePosition - pos;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}

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
}
