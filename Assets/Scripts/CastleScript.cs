using UnityEngine;
using System.Collections;

public enum Dir {North, South, East, West}

public class CastleScript : MonoBehaviour {
	public GUIContolScript gcs;
	//The x and y coordinates for the castle, for convenience
	private float x;
	private float y;
	//Width and height of the castle, used for calculations
	private float width = 454f/150f;
	private float height = 340f/150f;
	//Movement variables - moveSpeed is how fast, moveDir is what direction, autoMove dictates whether the castle moves
	//automatically instead
	private float moveSpeed;
	private Dir moveDir;
	private bool autoMove;
	//The location of the upper left corner of the castle
	private float upBound;
	private float leftBound;
	// Use this for initialization
	void Start () {
		//Set defaults
		moveSpeed = .5f;
		moveDir = Dir.North;
		autoMove = true;
		//Set locations
		x = transform.position.x;
		y = transform.position.y;
		upBound = y - height/2f;
		leftBound = x - width/2f;
	}
	// Update is called once per frame
	void Update () {
		//Update locations
		x = transform.position.x;
		y = transform.position.y;
		upBound = y - height/2f;
		leftBound = x - width/2f;
	}
	//When the castle is clicked, open up the city dialogue	
	void OnMouseDown(){
		gcs.castleClicked = true;
	}
	//----------------------------Get and Set methods--------------------------------------
	public float getX(){
		return x;
	}
	public float getY(){
		return y;
	}
	public float getUpBound(){
		return upBound;
	}
	public float getLeftBound(){
		return leftBound;
	}
	public float getWidth(){
		return width;
	}
	public float getHeight(){
		return height;
	}
	public float getMoveSpeed(){
		return moveSpeed;
	}
	public void setMoveSpeed(float mS){
		moveSpeed = mS;
	}
	public Dir getMoveDir(){
		return moveDir;
	}
	public void setMoveDir(Dir dir){
		moveDir = dir;
	}
	public bool getAutoMove(){
		return autoMove;
	}
	public void setAutoMove(bool am){
		autoMove = am;
	}
	//---------------------------End Get and Set Methods-------------------------------------
}
