using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FollowCamera : MonoBehaviour
{
    public GameObject camera;
    public bool isHead;
    private Vector3 xzpos;
    private Vector3 xyzpos;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        
        view = this.GetComponent<PhotonView>();
        // if (this.view.IsMine){
        //     this.view.RequestOwnership();
        // }

    }

    // Update is called once per frame
    void Update()
    {

        if (this.view.IsMine){
        
            if(isHead){
                xyzpos = new Vector3(camera.transform.position.x,this.transform.position.y,camera.transform.position.z);
                this.transform.rotation = camera.transform.rotation;  //Quaternion.Euler(transform.rotation.x, transform.rotation.y, camera.transform.rotation.x);
                this.transform.position = xyzpos;
            }
            else{
                xzpos = new Vector3(camera.transform.position.x,this.transform.position.y,camera.transform.position.z);
                this.transform.position = xzpos;
            }

        }
        
    }
}
