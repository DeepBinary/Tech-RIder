using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using Cinemachine;

public class CarController : MonoBehaviour
{
    #region Variables
    // Movement
    [Header("Movement")]
	public float speed = 20f;
	public float rotationSpeed = 2f;

	[Space(15f)]
	public Vector2 Jumpforce;
	[HideInInspector] public bool ismoveing = true;
	[HideInInspector] public bool isGrounded = false;
    	[HideInInspector] public bool moveback = false;
	[HideInInspector] public bool move = false;
	[HideInInspector] public bool Jump = false;
	[HideInInspector] public bool move_Right_side = false;
	[HideInInspector] public bool move_left_side = false;


	// BackEnd References
	private Rigidbody2D rb;
	private PolygonCollider2D polygoncollider;

	// post processing
	[Header("Post Processing")]
	public Camera GameCamera;
    #endregion

    Vector2 mousepos;
	private void Update()
	{
		if (ismoveing == true)
		{		

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
			rb.velocity = Jumpforce;
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
