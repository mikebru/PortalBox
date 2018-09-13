using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour {

    public Transform playerCamera;
    public Transform Portal;
    public Transform otherPortal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Vector3 CamOffset = playerCamera.position - otherPortal.position;

        // transform.position = Portal.position + CamOffset;

        transform.localPosition = playerCamera.localPosition;

        float angularDifference = Quaternion.Angle(Portal.rotation, otherPortal.rotation);

        Quaternion portalRotDifference = Quaternion.AngleAxis(angularDifference, Vector3.up);
        Vector3 newCameraDirection = portalRotDifference * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
		
	}
}
