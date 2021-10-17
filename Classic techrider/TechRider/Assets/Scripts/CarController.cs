using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CarController : MonoBehaviour 
{ 
	bool isGrounded = false;
    bool moveback = false;
	bool move = false;
	bool Jump = false;
	bool move_Right_side = false;
	bool move_left_side = false;	

	public bool IsHardmode;
	private Rigidbody2D rb;
	private PolygonCollider2D polygoncollider;

	public float speed = 20f;
	public float rotationSpeed = 2f;

	public Vector2 Jumpforce;


	public PostProcessVolume PostprocessingVolume;

	private ChromaticAberration chromaticalberation;
	private Vignette vignette;
	private Bloom Bloom;
	private LensDistortion Lensdistortion;

	private void Update()
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
		if(Input.GetKeyDown(KeyCode.S))
        {
			moveback = true;
        }
		if (Input.GetKeyUp(KeyCode.S))
        {
			moveback = false;
        }


		// A key
		if(Input.GetKeyDown(KeyCode.A))
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

	private void FixedUpdate()
	{
		

		if (Jump == true)
        {			
			if (!IsHardmode)
            {
				rb.velocity = Jumpforce;

				SlowmotionEnter(0.5f);
			}			
        }

		if (Jump == false)
		{
			if (!IsHardmode)
            {
				SlowMotionExit();
            }
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

		if (move_left_side == true)
        {
			if (!isGrounded)
            {
				rb.AddTorque(rotationSpeed);
				rb.AddForce(new Vector2(-speed, 0));
            }
        }

		if (move_Right_side == true)
        {
			if(!isGrounded)
            {
				rb.AddTorque(-rotationSpeed);
				rb.AddForce(new Vector2(speed, 0));
			}
        }
	}

	private void OnCollisionEnter2D()
	{
		isGrounded = true;
	}

	private void OnCollisionExit2D()
	{
		isGrounded = false;
	}

	public void SlowmotionEnter(float timescale)
    {
		Time.timeScale = timescale;

		PostprocessingVolume.profile.TryGetSettings(out vignette);
		PostprocessingVolume.profile.TryGetSettings(out chromaticalberation);
		PostprocessingVolume.profile.TryGetSettings(out Bloom);
		chromaticalberation.intensity.value = 1f;
		vignette.smoothness.value = 1f;
		Bloom.intensity.value = 10f;
	}

	public void SlowMotionExit()
    {
		Time.timeScale = 1f;

		PostprocessingVolume.profile.TryGetSettings(out vignette);
		PostprocessingVolume.profile.TryGetSettings(out chromaticalberation);
		PostprocessingVolume.profile.TryGetSettings(out Bloom);
		chromaticalberation.intensity.value = 0;
		vignette.smoothness.value = 0.4f;
		Bloom.intensity.value = 5f;
	}

    private void Start()
    {
		polygoncollider = GetComponent<PolygonCollider2D>();
		Destroy(polygoncollider);
		gameObject.AddComponent<PolygonCollider2D>();
    }
}
