using UnityEngine;
using System.Collections;

public class CastleScript : MonoBehaviour {
	public GUIContolScript gcs;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z)){
			gcs.go = true;
		}
	}
}
