using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public CharacterController2D player;
    float input;
    public bool jump = false;
    public float runSpeed = 40f;
    public Animator animator;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        animator.SetFloat("isRunning", Mathf.Abs(input));

        input = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) {
            
            animator.SetBool("isJumping", true);
            jump = true;
        }

	}
    void FixedUpdate() {

        player.Move(input * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Land() {
        
        animator.SetBool("isJumping", false);

    }
}
