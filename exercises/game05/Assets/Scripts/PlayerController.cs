using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
	public bool Selected = false;
	public GameObject frogCanvas; 
	public float Hunger = 0f;
    public float Socialize = 0f; 
    public string Mode;
    public CharacterController CC;
    public float MovementSpeed = 20f;
    public float RotationSpeed = 90f;
	public float yVelocity = 0;
	public float jumpForce = 0.3f;
	public float gravityModifier = 0.2f;
	public bool prevIsGrounded = true;
	public float MaxSocialize = 50f;


	void Start()
    {
    	frogCanvas.SetActive(false);
        
    }

    void Update()
    {
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		transform.Rotate(0, hAxis * RotationSpeed * Time.deltaTime, 0);


		if (!CC.isGrounded)
		{ 
			yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;
			if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0)
			{
				yVelocity = 0;
			}
		}
		else
		{
			if (!prevIsGrounded)
			{

				yVelocity = 0;
			}

			
			if (Input.GetKeyDown(KeyCode.Space))
			{
				yVelocity = jumpForce;
			}
		}

		
		Vector3 amountToMove = transform.forward * vAxis * MovementSpeed * Time.deltaTime;

		
		amountToMove.y = yVelocity;

	
		CC.Move(amountToMove);

	
		prevIsGrounded = CC.isGrounded;

		//if (Socialize == MaxSocialize)
       // {
			//Do Scene Manager
       // }
	

}

    void OnMouseDown() {
        if (Mode == "Feed") {
            Hunger -= 5;
        }
        else if (Mode == "Social") {
            Socialize += 5;
        }
      
    }

    private void OnMouseEnter()
    {
		frogCanvas.SetActive(true);
    }

    private void OnMouseExit()
    {
		frogCanvas.SetActive(false);
    }

}
