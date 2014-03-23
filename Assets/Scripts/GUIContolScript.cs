using UnityEngine;
using System.Collections;

public class GUIContolScript : MonoBehaviour {
	//Whether the dialogue should display
	public bool go;
	public GameObject source;
	public string buttonSelected;
	public bool pushed;
	//Center of the screen
	public float centerx;
	public float centery;
	//Size of dialogue
	public float height = 300;
	public float width = 300;
	//Margin between edge of dialogue background and dialogue content
	public float margin = 10;
	//Values for the upper left hand corner of background
	public float upback;
	public float leftback;
	//Coordinates of the upper left hand corner of the pop-up content
	public float upcontrol;
	public float leftcontrol;
	public float controlheight;
	public float controlwidth;
	public string dialogueText = "Please choose where you want your soldier to spawn:";
	// Use this for initialization
	void Start () {
		centerx = Screen.width/2f;
		centery = Screen.height/2f;
		upback = centery - height/2;
		leftback = centerx - width/2;
		upcontrol = upback + margin;
		leftcontrol = leftback + margin;
		controlheight = height - 2*margin;
		controlwidth = width - 2*margin;
		go = false;
		pushed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(pushed){
			//Call the recieving fn and pass it a string of N,S,E, or W
			//source.fn(buttonSelected);
			//Reset this script
			go = false;
			pushed = false;
		}
	}
	void OnGUI(){
		if(go && !pushed){
			//Background
			GUI.BeginGroup(new Rect(leftback, upback, width, height));
			GUI.Box(new Rect(0,0,width,height), "");
			//The Controls, for now
			GUI.BeginGroup(new Rect(margin, margin, controlwidth, controlheight));
			//Vertical "table", contents {dialogue text, dialogue options}
			GUILayout.BeginVertical(GUILayout.Width(controlwidth));
			GUILayout.Label(dialogueText);
			//Vertical "table", contents {{N},{W,E},{S}}
			GUILayout.BeginVertical(GUILayout.Width(controlwidth));
			//{N}
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			if(GUILayout.Button("N")){
				buttonSelected = "N";
				pushed = true;
			}
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			//Magic Numbery right now
			GUILayout.Space(50);
			//{W,E}
			GUILayout.BeginHorizontal();
			if(GUILayout.Button("W")){
				buttonSelected = "W";
				pushed = true;
			}
			GUILayout.FlexibleSpace();
			if(GUILayout.Button("E")){
				buttonSelected = "E";
				pushed = true;
			}
			GUILayout.EndHorizontal();
			//Same magic number as before
			GUILayout.Space(50);
			//{S}
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			if(GUILayout.Button("S")){
				buttonSelected = "S";
				pushed = true;
			}
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();
			GUILayout.EndVertical();
			GUI.EndGroup();
			GUI.EndGroup();
		}
	}
}