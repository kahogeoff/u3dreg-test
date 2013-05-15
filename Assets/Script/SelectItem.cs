using UnityEngine;
using System.Collections;

public class SelectItem : MonoBehaviour 
{
	
	public string UsingItem;
	public int debugNum;
	
	private int ItemIndex = 0;
	private ItemHolder IH;
	
	// Use this for initialization
	void Start () 
	{
		IH = GameObject.Find("ItemHolder").GetComponent<ItemHolder>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			ItemIndex ++;
		}
		if(Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			ItemIndex --;
		}
		
		if(ItemIndex < 0)
		{
			ItemIndex = 0;	
		}
		if(ItemIndex > (IH.ItemList.Count -1))
		{
			ItemIndex = (IH.ItemList.Count -1);
		}
		
		UsingItem = IH.ItemList[ItemIndex];
		debugNum = ItemIndex;
	}
}
