using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            anim.SetBool("iswalking", true);
        }

        else

        {
            anim.SetBool("iswalking", false);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isjumping", true);
        }
        else
        {
            anim.SetBool("isjumping", false);
        }


        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isback", true);
        }
        else
        {
            anim.SetBool("isback", false);
        }


         if (Input.GetKey(KeyCode.LeftShift))
        {

            anim.SetBool("isrun", true);
            
        }
        else
        {
            anim.SetBool("isrun", false);
        }

    }
}
