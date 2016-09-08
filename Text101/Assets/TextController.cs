using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour 
{
	public Text text;

	private enum States {cell, mirror0, mirror1, sheets0, lock0, cellMirror, sheets1, lock1, lock2, freedom};
	private States myState;

	void Start () 
	{
		myState = States.cell;
	
	}

	void Update () 
	{	
		print (myState);
		if (myState == States.cell) 				{StateCell();}
		else if (myState == States.sheets0)			{StateSheets0();}
		else if (myState == States.sheets1)			{StateSheets1();} 
		else if (myState == States.lock0)			{StateLock0();}
		else if (myState == States.lock1)			{StateLock1();} 
		else if (myState == States.lock2)			{StateLock2();}
		else if (myState == States.mirror0)			{StateMirror0();}
		else if (myState == States.mirror1)			{StateMirror1();}
		else if (myState == States.cellMirror)		{StateCellMirror();} 
		else if (myState == States.freedom)			{StateFreedom();} 
	}
	void StateCell ()
	{
		text.text = "You are in a prison cell, and you want to escape. There are " +
						"some dirty sheets on the bed, a mirror on the wall, and the door " +
						"is locked from the outside.\n\n" +
						"Press S to view sheets, M to view mirror, and L to view lock.";
		if (Input.GetKeyDown (KeyCode.S))			{myState = States.sheets0;}
		else if (Input.GetKeyDown (KeyCode.M))		{myState = States.mirror0;}
		else if (Input.GetKeyDown (KeyCode.L))		{myState = States.lock0;}
	}
	void StateSheets0 ()
	{
		text.text = "These are disgusting. Someone should change them. \n\n " +
					"Press R to return to cell.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.cell;}
	}
	void StateSheets1 ()
	{
		text.text = "Even with a mirror the sheets look pretty rough. \n\n " +
					"Press R to return to cell.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.cellMirror;}
	}
	void StateLock0()
	{
		text.text = "You position yourself to look out the barred window. " +
					"There's a key code lock on the other side of the wall." +
					"You don't know the code but saw in a movie one time that " +
					"you can look for the dirty fingerprints to find it." +
					"You can't do anything else without a better angle. \n\n" +
					"Press R to return to cell.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.cell;}
	}
	void StateLock1()
	{
		text.text = "The key code is on the opposite side of the wall. If you stick the mirror out " +
					"you might be able to take a look.\n\n" +
					"Press L to take a look.";

		if (Input.GetKeyDown (KeyCode.L))		{myState = States.lock2;}
	}
	void StateLock2()
	{
		text.text = "You put the mirror through the bars and turn it around to see the lock. " +
					"The finger print thing actually works, so you try a few combos " +
					"and eventually you hear a click. \n\n" +
					"Press O to open the door.";
		if (Input.GetKeyDown (KeyCode.O))		{myState = States.freedom;}
	}
	void StateMirror0()
	{
		text.text = "The mirror on the wall looks croocked. \n\n " +
					"Press F to fix it. Press R to return to cell.";
		if (Input.GetKeyDown (KeyCode.F))			{myState = States.mirror1;}
		else if (Input.GetKeyDown (KeyCode.R))		{myState = States.cell;}
	}
	void StateMirror1 ()
	{
		text.text = "Your good deed didn't work out, but now you have a mirror." +
					"\n\n Press R to return to cell";

		if (Input.GetKeyDown (KeyCode.R))			{myState = States.cellMirror;}
	}
	void StateCellMirror()
	{
		text.text = "The mirror isn't on the wall, but " +
					"everything else is as it was. \n\n" +
					"Press S to view sheets, L to view lock.";

		if (Input.GetKeyDown (KeyCode.S))			{myState = States.sheets1;}
		else if (Input.GetKeyDown (KeyCode.L))		{myState = States.lock1;}
	}
	void StateFreedom()
	{
		text.text = "The door opened! \n\n" +
					"Press R to replay.";

		if (Input.GetKeyDown (KeyCode.R))			{myState = States.cell;}
	}
}