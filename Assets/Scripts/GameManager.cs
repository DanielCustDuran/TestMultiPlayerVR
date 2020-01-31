using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("R00m", new RoomOptions { MaxPlayers = 3 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("On joined room");
        GameObject player = PhotonNetwork.Instantiate("LeapRightPlayer", new Vector3(Random.Range(-5, 5), 3f, Random.Range(-5, 5)), Quaternion.identity);
        //Transform holderCamera = capsule.transform.Find("HoldingCamera").transform;
        player.transform.Find("Main Camera").gameObject.GetComponent<Camera>().enabled = true;
        //capsule.AddComponent<Camera>();
        //camera.transform.position = holderCamera.position;
    }
}
