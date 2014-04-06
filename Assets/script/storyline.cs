using UnityEngine;
using System.Collections;

public class storyline : MonoBehaviour {
	string currentRoom = "begin";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "";
		if (currentRoom == "begin") {
			textBuffer = "Turtle is lost in the forest. \nPress [F] to help the turtle find the direction.\n" +
				"Press [I] to ignore the turtle and walk away.";
			if (Input.GetKeyDown (KeyCode.F) ) {
				currentRoom = "find";
			}
			if (Input.GetKeyDown (KeyCode.I) ) {
				currentRoom = "ignore";
			}
		}

		else if (currentRoom == "find") {
			textBuffer = "You are so kind. Turtle thank you with a precious gift.";
		}

		else if (currentRoom == "ignore") {
			textBuffer = "Wow, so mean. \nYou are going to get turtle punishment. \n" +
				"Press [A] to fight \nPress [R] to run";
			if (Input.GetKeyDown (KeyCode.A) ){
				currentRoom = "attack";
			}
			if (Input.GetKeyDown (KeyCode.R) ){
				currentRoom = "run";
			}

		}

		else if (currentRoom == "attack"){
			textBuffer = "Turtle attack is too strong. You are dead.";
		}

		else if (currentRoom == "run") {
			textBuffer = "You ran too fast, turtle couldn't catch up to you. \nYou survived!";
		}
		GetComponent <TextMesh> ().text = textBuffer;
	}
}
