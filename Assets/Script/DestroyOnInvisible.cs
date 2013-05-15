using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour 
{

	void Update()
	{
		if(!particleSystem.isPlaying)
		{
			Destroy(gameObject);	
		}
	}
}
