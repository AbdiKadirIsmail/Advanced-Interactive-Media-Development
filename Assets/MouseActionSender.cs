using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MouseActionSender : MonoBehaviour
{

	//TheBitCave.FungusUtils

	public Flowchart flowchart;
	public string onMouseDownMessage;
	public string onMouseEnterMessage;
	public string onMouseExitMessage;
	public string onMouseOverMessage;
	public string onMouseUpMessage;
	public string onMouseUpAsButtonMessage;

	void OnMouseDown()
	{
		if (!string.IsNullOrEmpty(onMouseDownMessage))
			flowchart.SendFungusMessage(onMouseDownMessage);
	}

	void OnMouseEnter()
	{
		if (!string.IsNullOrEmpty(onMouseEnterMessage))
			flowchart.SendFungusMessage(onMouseEnterMessage);
	}

	void OnMouseExit()
	{
		if (!string.IsNullOrEmpty(onMouseExitMessage))
			flowchart.SendFungusMessage(onMouseExitMessage);
	}

	void OnMouseOver()
	{
		if (!string.IsNullOrEmpty(onMouseOverMessage))
			flowchart.SendFungusMessage(onMouseOverMessage);
	}

	void OnMouseUp()
	{
		if (!string.IsNullOrEmpty(onMouseUpMessage))
			flowchart.SendFungusMessage(onMouseUpMessage);
	}

	void OnMouseUpAsButton()
	{
		if (!string.IsNullOrEmpty(onMouseUpAsButtonMessage))
			flowchart.SendFungusMessage(onMouseUpAsButtonMessage);
	}
}



