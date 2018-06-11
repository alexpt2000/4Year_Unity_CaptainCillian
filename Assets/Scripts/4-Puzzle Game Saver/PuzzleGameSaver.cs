using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class PuzzleGameSaver : MonoBehaviour
{

	private GameData gameData;

	public bool[] game1PuzzleLevels;
	public bool[] game2PuzzleLevels;
	public bool[] game3PuzzleLevels;

	public int[] game1PuzzleLevelStars;
	public int[] game2PuzzleLevelStars;
	public int[] game3PuzzleLevelStars;

	private bool isGameStartedForTheFirstTime;

	public float musicVolume;

	void Awake() {
		InitializeGame();
	}

	void InitializeGame()
	{

		LoadGameData();

		if (gameData != null)
		{
			isGameStartedForTheFirstTime = gameData.GetIsGameStartedForTheFirstTime();
		} else
		{
			isGameStartedForTheFirstTime = true;
		}

		if (isGameStartedForTheFirstTime)
		{
			isGameStartedForTheFirstTime = false;

			musicVolume = 0;

			game1PuzzleLevels = new bool[5];
            game2PuzzleLevels = new bool[5];
            game3PuzzleLevels = new bool[5];

			game1PuzzleLevels[0] = true;
            game2PuzzleLevels[0] = true;
            game3PuzzleLevels[0] = true;

			for (int i = 1; i < candyPuzzleLevels.Length; i++)
			{
                game1PuzzleLevels[i] = false;
                game2PuzzleLevels[i] = false;
                game3PuzzleLevels[i] = false;
			}



			game1PuzzleLevelStars = new int[5];
            game2PuzzleLevelStars = new int[5];
            game3PuzzleLevelStars = new int[5];

			for (int i = 0; i < game1PuzzleLevelStars.Length; i++)
			{
				candyPuzzleLevelStars[i] = 0;
				transportPuzzleLevelStars[i] = 0;
				fruitPuzzleLevelStars[i] = 0;

			}


			gameData = new GameData();

			gameData.SetGame1PuzzleLevels(game1PuzzleLevels);
			gameData.SetGame2PuzzleLevels(game2PuzzleLevels);
            gameData.SetGame3PuzzleLevels(game3PuzzleLevels);

            gameData.SetGame1PuzzleLevelStars(game1PuzzleLevelStars);
            gameData.SetGame2PuzzleLevelStars(game2PuzzleLevelStars);
            gameData.SetGame3PuzzleLevelStars(game3PuzzleLevelStars);

            gameData.SetIsGameStartedForTheFirstTime(isGameStartedForTheFirstTime);
			gameData.SetMusicVolume(musicVolume);

			SaveGameData();
			//LoadGameData();

		}


	}

	public void SaveGameData()
	{


		FileStream file = null;

		try
		{

			BinaryFormatter bf = new BinaryFormatter();

			file = File.Create(Application.persistentDataPath + "/GameData.dat");

            Debug.Log("Save the Game");

            if (gameData != null)
			{

				gameData.SetGame1PuzzleLevels(game1PuzzleLevels);
				gameData.SetGame2PuzzleLevels(game2PuzzleLevels);
				gameData.SetGame3PuzzleLevels(game3PuzzleLevels);

				gameData.SetGame1PuzzleLevelStars(game1PuzzleLevelStars);
				gameData.SetGame2PuzzleLevelStars(game2PuzzleLevelStars);
				gameData.SetGame3PuzzleLevelStars(game3PuzzleLevelStars);

				gameData.SetIsGameStartedForTheFirstTime(isGameStartedForTheFirstTime);
				gameData.SetMusicVolume(musicVolume);

				bf.Serialize(file, gameData);





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


	void LoadGameData()
	{

		FileStream file = null;

		try
		{
			BinaryFormatter bf = new BinaryFormatter();

			file = File.Open(Application.persistentDataPath + "/CaptainCillian.dat", FileMode.Open);

			gameData = (GameData)bf.Deserialize(file);

            Debug.Log("Load the Game");



            if (gameData != null)
			{
				game1PuzzleLevels = gameData.GetGame1PuzzleLevels();
                game2PuzzleLevels = gameData.GetGame2PuzzleLevels();
                game3PuzzleLevels = gameData.GetGame3PuzzlePuzzleLevels();

                game1PuzzleLevelStars = gameData.GetGame1PuzzleLevelStars();
                game2PuzzleLevelStars = gameData.GetGame2PuzzleLevelStars();
                game3PuzzleLevelStars = gameData.GetGame3PuzzleLevelStars();


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

	public void Save(int level, string selectedPuzzle, int stars)
	{

		int unlockNextLevel = -1;

		switch (selectedPuzzle)
		{
			case "Game1 Puzzle":

				unlockNextLevel = level + 1;

				game1PuzzleLevelStars[level] = stars;

				if (unlockNextLevel < game1PuzzleLevels.Length)
				{
                    game1PuzzleLevels[unlockNextLevel] = true;
				}

				break;

				case "Game2 Puzzle":

				unlockNextLevel = level + 1;

                game2PuzzleLevelStars[level] = stars;

				if (unlockNextLevel < game2PuzzleLevels.Length)
				{
                    game2PuzzleLevels[unlockNextLevel] = true;
				}

				break;

				case "Game3 Puzzle":

				unlockNextLevel = level + 1;

                game3PuzzleLevelStars[level] = stars;

				if (unlockNextLevel < game3PuzzleLevels.Length)
				{
                    game3PuzzleLevels[unlockNextLevel] = true;
				}

				break;
		}

	}
}
