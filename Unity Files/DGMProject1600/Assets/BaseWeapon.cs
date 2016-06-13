using UnityEngine;
using System.Collections;

public class BaseWeapon : MonoBehaviour {

	public BaseAmmo thisAmmo;


	// Use this for initialization
	void Start () 
	{
		thisAmmo = new BaseAmmo ();
		thisAmmo.ammoCount = 10000;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		thisAmmo.Fire ();
	
	}
}
