using UnityEngine;
using System.Collections;

[System.Serializable]

public class FlavorsClass {

	// Needs to not be mono (it will be instance in other scripts)
	// Needs to be serialized (maybe)

	// String of the flavor names

	public string flavorName;
	// int of bonus num

	public int flavorBonusValue;
}
