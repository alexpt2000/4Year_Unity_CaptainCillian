using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{


	[SerializeField]
	private PuzzleGameSaver puzzleGameSaver;

	[SerializeField]
	private GameObject[] levelStarsHolders;

	[SerializeField]
	private GameObject[] levelsPadlocks;


	private bool[] candyPuzzleLevels;
	private bool[] transportPuzzleLevels;
	private bool[] fruitPuzzleLevels;

	public void CheckWhichLevelsAreUnlocked(string selectePuzzle)
	{


	}

	void DeactivatePadlocksAndStarHolders() { 
	
	
	}

	void GetLevels() { 
	
	}


	public bool[] GetPuzzleLevels(string selectedPuzzle) {

		return null;
	}

}
