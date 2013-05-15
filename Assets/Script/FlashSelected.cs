using UnityEngine;
using System.Collections;

public class FlashSelected : MonoBehaviour 
{
	public float flashRate = 1.0f;
	public GameObject unitObject = null;
	
	private Color originalColor;
	
	private UnitManager unitManager;
	
	private bool coroutineRunning = false;
	
	// Use this for initialization
	void Start () 
	{	
		if(unitObject == null)
		{
			unitObject = gameObject;	
		}
		unitManager = GameObject.FindGameObjectWithTag("PlayerUnitManager").GetComponent<UnitManager>();
		originalColor = renderer.material.color;
		StartCoroutine("Flash");
	}
	
	void Update()
	{
		if(unitManager.IsSelected(unitObject))
		{
			if(!coroutineRunning)
			{
				coroutineRunning = true;
				StartCoroutine("Flash");

			}
		}else{
			coroutineRunning = false;
			StopAllCoroutines();
			renderer.material.color = originalColor;
		}
	}
	
	// Update is called once per frame
	IEnumerator Flash () 
	{
		float t = 0;
		while(t < flashRate)
		{
			renderer.material.color = Color.Lerp(originalColor,Color.white,t/flashRate);
			t += Time.deltaTime;
			yield return null;
		}
		renderer.material.color = Color.white;
		StartCoroutine("Return");
	}
	
	IEnumerator Return()
	{
		float t = 0;
		while(t < flashRate)
		{
			renderer.material.color = Color.Lerp(Color.white,originalColor,t/flashRate);
			t += Time.deltaTime;
			yield return null;
		}
		renderer.material.color = originalColor;
		StartCoroutine("Flash");
	}
}
