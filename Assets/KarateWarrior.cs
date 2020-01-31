using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateWarrior : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Debug.Log(input.normalized);
        if (input.normalized.magnitude != 0)
        {
            if(input.normalized.z == 1)
            {
            //rb.MovePosition(rb.position + input.normalized * Time.deltaTime * 5f);
                animator.SetBool("Moving", true);

            }
            else
            {
                transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y + 180f, transform.rotation.z, 0);
                animator.SetBool("Moving", true);
            }
           

        }
        else
        {
            animator.SetBool("Moving", false);

        }
    }
}
