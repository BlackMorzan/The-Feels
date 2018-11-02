using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour 
{

  public CharacterController2D controller;
  public ShakeControl Shake;
  float horiMove = 0f;
  public float speed = 40f;
  //public float jumpspeed = 1;
  public Animator animator;

  private bool jump = false;
  private bool crouch = false;
  private bool isShaking = false;
  
  

	void Update () 
	{
	  
	  horiMove = Input.GetAxisRaw("Horizontal") * speed;
	  
	  animator.SetFloat("Speed", Mathf.Abs(horiMove));
	  
	  if (Input.GetButtonDown("Jump"))
	  {
	    jump = true;
	    
	    animator.SetBool("In_Air", true);
	  } 
	    
	  if (Input.GetButtonDown("Crouch"))
	    crouch = true;  
	  else
	    if (Input.GetButtonUp("Crouch"))
	      crouch = false;
	      
	  
	  //Debug.Log (jump);
	}
	
	public void Landing()
	{
	  animator.SetBool("In_Air", false);
	}
	
	void FixedUpdate () 
	{
	  controller.Move(horiMove * Time.fixedDeltaTime, crouch, jump);
	  
	  jump = false;
	}
}
