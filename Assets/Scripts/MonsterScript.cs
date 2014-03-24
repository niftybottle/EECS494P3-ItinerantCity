using UnityEngine;
using System.Collections;

public class MonsterScript : MonoBehaviour {
	public GameObject go;
	public float speed;
	// Use this for initialization
	void Start () {
		go = GameObject.Find("Castle");
		speed = .5f;
	}
	
	// Update is called once per frame
	void Update () {
		if(go.transform.position.x > gameObject.transform.position.x +.1){
			gameObject.transform.Translate(new Vector3(speed*Time.deltaTime,0));
		}else if (go.transform.position.x < gameObject.transform.position.x - .1){
			gameObject.transform.Translate(new Vector3(-speed*Time.deltaTime,0));
		}else if (go.transform.position.y > gameObject.transform.position.y + .1){
			gameObject.transform.Translate(new Vector3(0,speed*Time.deltaTime));
		}else if (go.transform.position.y < gameObject.transform.position.y - .1){
			gameObject.transform.Translate(new Vector3(0,-speed*Time.deltaTime));
		}
	}
}
