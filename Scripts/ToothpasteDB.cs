using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ToothpasteDB : ScriptableObject
{

	public Toothpaste[] character;
   	
	public int characterCount
	{
		get
		{
			return character.Length;
		}
	
	}

	public Toothpaste getCharacter(int index){
	return character[index];
	}
}
