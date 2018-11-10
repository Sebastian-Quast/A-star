using System;
using System.Collections.Generic;
using UnityEngine;

public class Node {

	public List<Node> adjacent = new List<Node>();
	public Node previous;
	public String label = "";

	public void clear()
	{
		previous = null;
	}

}
