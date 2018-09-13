using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBox : MonoBehaviour {


    public Transform otherPortal;
    public Transform portalCamera;
    public Transform otherCamera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Vector3 CamOffset = otherPortal.position - otherCamera.position;

        //transform.position = portalCamera.position + CamOffset;

        transform.localPosition = otherPortal.transform.localPosition;

        transform.rotation = otherPortal.rotation;

    }
}
