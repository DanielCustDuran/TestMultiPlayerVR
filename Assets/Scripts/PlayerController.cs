using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerController : MonoBehaviourPun, IPunObservable
{
    Renderer rend;
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    PhotonView _photonView;
    Vector3 inputMovement;
    public Camera camera;

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
        rend = GetComponent<Renderer>();
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = new Color(
              Random.Range(0f, 1f),
              Random.Range(0f, 1f),
              Random.Range(0f, 1f)
          );
        
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
