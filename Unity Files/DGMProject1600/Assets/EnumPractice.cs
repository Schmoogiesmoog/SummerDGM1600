﻿using UnityEngine;
using System.Collections;

public class EnumPractice : MonoBehaviour {

	public enum MyOperations { ADD, SUBTRACT, MULTIPLY, DIVIDE, SQUARE };

	public MyOperations currentOperation;

	public int num_one;
	public int num_two;


	int ChangeOperation (int _one, int _two){
		int value = 0;

		switch (currentOperation) {
		case MyOperations.ADD:
			value = _one + _two;
			break;

		case MyOperations.SUBTRACT:
			value = _one - _two;
			break;

		case MyOperations.MULTIPLY:
			value = _one * _two;
			break;

		case MyOperations.DIVIDE:
			value = _one / _two;
			break;

		case MyOperations.SQUARE:
			value = (_one + _two) * (_one + _two);
			break;
		}
		return value;
	}
	// Use this for initialization
	void OnMouseDown () {
		int finalValue = ChangeOperation (num_one, num_two);
		print (finalValue);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
