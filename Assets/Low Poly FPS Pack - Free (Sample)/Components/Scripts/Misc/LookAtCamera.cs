using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// ----- Low Poly FPS Pack Free Version -----
public class LookAtCamera : MonoBehaviourPunCallbacks {

	private void Start () 
	{
		//Fix inverted scale issue
		gameObject.transform.localScale = 
			new Vector3 (-1, 1, 1);
	}
		
	private void Update () 
	{
        if (!photonView.IsMine) return;
        //Object always face camera
        transform.LookAt (Camera.main.transform);
	}
}
// ----- Low Poly FPS Pack Free Version -----