using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = new Color(
            Random.Range(0f,1f),
            Random.Range(0f,1f),
            Random.Range(0f,1f)
        );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
