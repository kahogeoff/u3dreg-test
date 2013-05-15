using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemHolder : MonoBehaviour 
{
	public List<string> ItemList;
	public GameObject player;
	public bool debug;
	
	private GameObject target;
	private UnitManager unitManager;
		
	// Use this for initialization
	void Start () 
	{
		unitManager = GameObject.FindGameObjectWithTag("PlayerUnitManager").GetComponent<UnitManager>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		target = unitManager.selectedUnits[0];
		
		float distance = Vector3.Distance(target.transform.position, player.transform.position);
			
		if(debug==true)
		{
			Debug.Log(distance);
		}
		
		if(Input.GetKeyDown(KeyCode.E))
		{
			if(distance <= 2.2f)
			{	
				AddObjToList();
			}
		}	
	}
	
	void AddObjToList()
	{
		ItemList.Add(target.name);
		Destroy(target);
		unitManager.DeselectAllUnits();
	}
	
}
