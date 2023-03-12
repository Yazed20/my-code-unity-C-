using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = 20f;
    public float horizontal;
    public float vertical;
    public float jump = 4.5f;
    public float rotspeed = 80f;
   // public float rot = 0f;

    public CharacterController controller;
    Vector3 movedirection = Vector3.zero;

    void Start()
    {
        controller.GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            movedirection = new Vector3(horizontal, 0.0f, vertical);
            movedirection *= speed;
            movedirection = transform.TransformDirection(movedirection);
            if (Input.GetButtonUp("Jump"))
            {
                movedirection.y = jump;
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            speed = 5f;
            
        }if(Input.GetKeyUp(KeyCode.LeftShift)){
            speed = 2.5f;
        }
       //rot += Input.GetAxis("Horizontal") * rotspeed * Time.fixedDeltaTime;
       // transform.eulerAngles = new Vector3(0, rot, 0);
        movedirection.y -= gravity * Time.deltaTime;
        controller.Move(movedirection * Time.deltaTime);
    }
}
