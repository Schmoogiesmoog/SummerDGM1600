using UnityEngine;
using System.Collections;

[System.Serializable]

public class BaseAmmo {

	//Controls the amount and power level of the ammo
	public int ammoCount;
	public int ammoPower;

	// This function runs when called for a weapon
	public void Fire()
	{
		if (ammoCount > 0) 
		{
			ammoCount--;
			Debug.Log (ammoCount);
		} 
		else 
		{
			Debug.Log ("Out of ammo!");
		}

	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
