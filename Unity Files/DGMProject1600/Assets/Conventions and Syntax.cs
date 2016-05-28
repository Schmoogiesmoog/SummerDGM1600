using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour
{
	void Start ()
	{
		Debug.Log(transform.position.x);

		if(transform.position.y <= 5f)
		{
			Debug.Log ("This is my proof of knowing conventions and syntax in coding!");

			Debug.Log ("My kids were sick this week so I couldn't make it to class but" +
			"I definitely know conventions and syntax beacuse I have previously taken a C# and C++" +
			"class at BYU and UVU!");
		}
	}
}