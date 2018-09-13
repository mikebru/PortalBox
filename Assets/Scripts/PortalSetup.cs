using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSetup : MonoBehaviour {

    public Camera portalCam;

    public Material portalMat;

	// Use this for initialization
	void Start () {
		
        if(portalCam.targetTexture != null)
        {
            portalCam.targetTexture.Release();
        }

        portalCam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

        portalMat.mainTexture = portalCam.targetTexture;
	}
	
}
