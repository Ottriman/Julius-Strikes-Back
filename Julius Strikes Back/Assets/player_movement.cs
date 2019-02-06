using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    public CharacterController2D controller;

    float horizontal_move = 0f;
    float vertical_move = 0f;
	
	// Update is called once per frame
	void Update () {

        horizontal_move = Input.GetAxisRaw("Horizontal");
        vertical_move = Input.GetAxisRaw("Vertical");
	}

    private void FixedUpdate()
    {
        //Move character

        controller.Move(horizontal_move, false, false);
        controller.Move(vertical_move, false, false);
    }
}
