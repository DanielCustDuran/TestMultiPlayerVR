using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeDestination", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeDestination()
    {
        transform.position = new Vector3(Random.Range(-20, 20), transform.position.y, Random.Range(-20, 20));  
    }
}
