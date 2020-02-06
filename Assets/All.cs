using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class All : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        foreach(var gO in GetComponentsInChildren<Transform>())
        {
            Debug.Log("daaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            gO.gameObject.AddComponent<PhotonView>();
            gO.gameObject.AddComponent<PhotonTransformViewClassic>();
            gO.gameObject.GetComponent<PhotonView>().ObservedComponents.Add(gO.gameObject.GetComponent<PhotonTransformViewClassic>());
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
