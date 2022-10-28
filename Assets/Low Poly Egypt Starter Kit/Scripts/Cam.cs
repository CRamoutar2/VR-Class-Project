using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

    public int CamIndex;
    public Vector3[] CameraVector;

	void Update () {
	 if (Input.GetButtonDown("Fire1")) {CamIndex++;}
     if (Input.GetButtonDown("Fire2")) { CamIndex--; }
     if (CamIndex == CameraVector.Length ) { CamIndex = 0; }
     if (CamIndex < 0) { CamIndex = CameraVector.Length - 1; }
     transform.position = CameraVector[CamIndex];
	}
}
