using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{


	[SerializeField]
	private PuzzleGameSaver puzzleGameSaver;

	[SerializeField]
	private StarsLocker starsLocker;

	[SerializeField]
	private GameObject[] levelStarsHolders;

	[SerializeField]
	private GameObject[] levelsPadlocks;


	private bool[] game1PuzzleLevels;
	private bool[] game2PuzzleLevels;
	private bool[] game3PuzzleLevels;



	void Awake() {
		DeactivatePadlocksAndStarHolders();
	
	}

	void Start() {
		GetLevels();
	}

	public void CheckWhichLevelsAreUnlocked(string selectePuzzle)
	{
		DeactivatePadlocksAndStarHolders();
		GetLevels();

		switch (selectePuzzle)
		{
			case "Game1 Puzzle":

				for (int i = 0; i < game1PuzzleLevels.Length; i++)
				{
					if (game1PuzzleLevels[i])
					{
						levelStarsHolders[i].SetActive(true);
						starsLocker.ActivateStars(i, selectePuzzle);
					}else
					{
						levelsPadlocks[i].SetActive(true);
					}
				}

				break;


				case "Game2 Puzzle":

				for (int i = 0; i < game2PuzzleLevels.Length; i++)
				{
					if (game2PuzzleLevels[i])
					{
						levelStarsHolders[i].SetActive(true);
						starsLocker.ActivateStars(i, selectePuzzle);
					}
					else
					{
						levelsPadlocks[i].SetActive(true);
					}
				}

				break;

				case "Game3 Puzzle":

				for (int i = 0; i < game3PuzzleLevels.Length; i++)
				{
					if (game3PuzzleLevels[i])
					{
						levelStarsHolders[i].SetActive(true);
						starsLocker.ActivateStars(i, selectePuzzle);
					}
					else
					{
						levelsPadlocks[i].SetActive(true);
					}
				}

				break;
		}



	}

	void DeactivatePadlocksAndStarHolders()
	{
		for (int i = 0; i < levelsPadlocks.Length; i++)
		{
			levelStarsHolders[i].SetActive(false);
			levelsPadlocks[i].SetActive(false);

		}

	}

	void GetLevels()
	{
        game1PuzzleLevels = puzzleGameSaver.game1PuzzleLevels;
        game2PuzzleLevels = puzzleGameSaver.game2PuzzleLevels;
        game3PuzzleLevels = puzzleGameSaver.game3PuzzleLevels;


	}


	public bool[] GetPuzzleLevels(string selectedPuzzle)
	{

		switch (selectedPuzzle)
		{
			case "Game1 Puzzle":
				return this.game1PuzzleLevels;
				break;

			case "Game2 Puzzle":
				return this.game2PuzzleLevels;
				break;

			case "Game3 Puzzle":
				return this.game3PuzzleLevels;
				break;



			default:
				return null;
				break;
		}

	}

}
