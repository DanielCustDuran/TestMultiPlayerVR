using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dsadasdasas]");
        Vector3 inputMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position += inputMovement.normalized * Time.deltaTime * 10.0f;
    }
}
