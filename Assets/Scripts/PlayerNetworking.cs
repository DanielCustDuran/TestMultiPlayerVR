﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Leap.Unity;

public class PlayerNetworking : MonoBehaviour
{
    public LeapXRServiceProvider[] scriptsToIgnore;
    private PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            foreach(var script in scriptsToIgnore)
            {
                script.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}