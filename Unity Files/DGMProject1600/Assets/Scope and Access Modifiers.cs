using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ScopeandAccessModifiers : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	    double jack = .12;
		double firstMate = .08;
		int fund = 0;
		double goldRunning = 500;
		int numPeople = 10;

		// Calculate, using expressions, the amount the captain receives
		int captainsAmt = (int)Math.Floor(jack * goldRunning);
		goldRunning = goldRunning - captainsAmt;

		// Calculate the amount the first mate receives
		int firstmateAmt = (int)Math.Floor(firstMate * goldRunning);
		goldRunning = goldRunning - firstmateAmt;

		// Calculate the amount the rest of the crew receives
		// Any remainders goes to the fund
		fund =(int)(goldRunning % numPeople);
		int share = (int)(goldRunning - fund) / numPeople;

		// Print results to user
		print("The captain gets {0} gold", captainsAmt + share);
		print("The first mate gets {0} gold", firstmateAmt + share);
		print("The crew gets {0} gold",share);
		print("The PBA gets {0} gold", fund);
	
	}

}
