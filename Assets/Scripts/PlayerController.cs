using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerController : MonoBehaviourPun, IPunObservable
{
    
    PhotonView _photonView;
    Vector3 inputMovement;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(this.inputMovement);
        }
        else
        {
            this.inputMovement = (Vector3)stream.ReceiveNext();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _photonView = GetComponent<PhotonView>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_photonView.IsMine && PhotonNetwork.IsConnected) return;
        Debug.Log("Is mine");
        this.inputMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        this.transform.position += inputMovement.normalized * Time.deltaTime * 10f;
    }
}
