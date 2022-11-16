using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHand : MonoBehaviour
{
    public GameObject handToFollow;
    public GameObject offset;
    private Vector3 prevHandPos;

    void Start()
    {
        prevHandPos = handToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = (transform.TransformPoint(offset.transform.position) + prevHandPos - new Vector3(handToFollow.transform.position.x,handToFollow.transform.position.y,handToFollow.transform.position.z)) * Time.deltaTime;
        this.transform.rotation = handToFollow.transform.rotation;
        prevHandPos = handToFollow.transform.position;
    }
}
