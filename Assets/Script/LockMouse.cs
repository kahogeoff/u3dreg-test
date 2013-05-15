using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour {
	public GameObject cursor;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;
		Screen.lockCursor = false;
	}
}
