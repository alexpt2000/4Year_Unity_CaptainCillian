using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class PuzzleGameSaver : MonoBehaviour {

	private GameData gameData;

	private bool[] candyPuzzleLevels;
	private bool[] transportPuzzleLevels;
	private bool[] fruitPuzzlePuzzleLevels;

	private int[] candyPuzzleLevelStars;
	private int[] transportPuzzleLevelStars;
	private int[] fruitPuzzleLevelStars;

	private bool isGameStartedForTheFirstTime;

	private float musicVolume;

	void InitializeGame() { 
	
	
	}

	void SaveGameData() {


		FileStream file = null;

		try
		{

			BinaryFormatter bf = new BinaryFormatter();

			file = File.Create(Application.persistentDataPath + "/GameData.dat");

			if (gameData != null)
			{

				gameData.SetCandyPuzzleLevels(candyPuzzleLevels);


			}


		}
		catch (Exception e)
		{

		}

	}


	void LoadGameData() { 
	
	}

	public void Save(int level, string selectedPuzzle, int stars) { 
		
	}
}
