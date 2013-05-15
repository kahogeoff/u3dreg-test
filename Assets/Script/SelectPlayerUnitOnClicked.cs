using UnityEngine;
using System.Collections;

public class SelectPlayerUnitOnClicked : MonoBehaviour {
	
	private UnitManager unitManager;
	
	void Start()
	{
		unitManager = GameObject.FindGameObjectWithTag("PlayerUnitManager").GetComponent<UnitManager>();
	}
	
	// Use this for initialization
	void Clicked()
	{
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			unitManager.SelectAdditionalUnit(gameObject);
		} else {
			//Tell the Player Unit Manager to select this object
			unitManager.SelectSingleUnit(gameObject);
		}
	}
}
