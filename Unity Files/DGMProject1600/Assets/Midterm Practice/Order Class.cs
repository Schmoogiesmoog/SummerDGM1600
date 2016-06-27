using UnityEngine;
using System.Collections;

public class OrderClass : MonoBehaviour {

	// Needs to run
	// 1. Cube with a box collider
	// 2. This script as a component on the cube

	// var that takes the order of scoops from the editor
	public FlavorsClass[] myOrder;


	public ScoopAdderClass myScoopAdder;

	void OrderReady (){

		// Print the order


	}
	// OnMouseDown Event is used
	void OnMouseDown(){

		// function that processes the order by adding the the number of scoops
		// will reference the scoop class to process the order
		// we need to know the scoop flavors with the number of scoops


		// Is called at the end of the process function
		// function that completes the order and tells the buyer its finished





	}


	// If bonus num is reached, user can add sprinkles for free
	// FUnction that activates sprinkles
}
