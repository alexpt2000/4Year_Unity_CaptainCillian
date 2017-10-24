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
				gameData.SetTransportPuzzleLevels(transportPuzzleLevels);
				gameData.SetFruitPuzzlePuzzleLevels(fruitPuzzlePuzzleLevels);

				gameData.SetCandyPuzzleLevelStars(candyPuzzleLevelStars);
				gameData.SetTransportPuzzleLevelStars(transportPuzzleLevelStars);
				gameData.SetFruitPuzzleLevelStars(fruitPuzzleLevelStars);

				gameData.SetIsGameStartedForTheFirstTime(isGameStartedForTheFirstTime);
				gameData.SetMusicVolume(musicVolume);

				bf.Serialize(file, gameData);





			}


		}
		catch (Exception e)
		{

		}
		finally { 
		
			if (file != null)
			{
				file.Close();

			}
		
		}

	}


	void LoadGameData() {

		FileStream file = null;

		try
		{
			BinaryFormatter bf = new BinaryFormatter();

			file = File.Open(Application.persistentDataPath + "/GameData.dat", FileMode.Open);

			gameData = (GameData)bf.Deserialize(file);

			if (gameData != null)
			{
				candyPuzzleLevels = gameData.GetCandyPuzzleLevels();
				transportPuzzleLevels = gameData.GetTransportPuzzleLevels();
				fruitPuzzlePuzzleLevels = gameData.GetFruitPuzzlePuzzleLevels();

				candyPuzzleLevelStars = gameData.GetCandyPuzzleLevelStars();
				transportPuzzleLevelStars = gameData.GetTransportPuzzleLevelStars();
				fruitPuzzleLevelStars = gameData.GetFruitPuzzleLevelStars();


				musicVolume = gameData.GetMusicVolume();

			}
		}
		catch (Exception e)
		{

		}
		finally
		{

			if (file != null)
			{
				file.Close();

			}

		}

	}

	public void Save(int level, string selectedPuzzle, int stars) { 
		
	}
}
