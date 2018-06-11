using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsLocker : MonoBehaviour
{

	[SerializeField]
	private PuzzleGameSaver puzzleGameSaver;

	[SerializeField]
	private GameObject[] level1Stars, level2Stars, level3Stars, level4Stars, level5Stars;

	public int[] game1PuzzleLevelStars;
	public int[] game2PuzzleLevelStars;
	public int[] game3PuzzleLevelStars;

	void Awake()
	{

	}

	void Start()
	{

	}


	public void ActivateStars(int level, string selectedPuzzle)
	{

		GetStars();

		int stars;

		switch (selectedPuzzle)
		{
			case "Game1 Puzzle":

				stars = game1PuzzleLevelStars[level];
				ActivateLevelStars(level, stars);

				break;

			case "Game2 Puzzle":

				stars = game2PuzzleLevelStars[level];
				ActivateLevelStars(level, stars);

				break;

			case "Game3 Puzzle":

				stars = game3PuzzleLevelStars[level];
				ActivateLevelStars(level, stars);

				break;

		}

	}

	void ActivateLevelStars(int level, int looper)
	{
		switch (level)
		{
			case 0:

				if (looper != 0)
				{
					for (int i = 0; i < looper; i++)
					{
						level1Stars[i].SetActive(true);
					}
				}

				break;

			case 1:

				if (looper != 0)
				{
					for (int i = 0; i < looper; i++)
					{
						level2Stars[i].SetActive(true);
					}
				}

				break;

			case 2:

				if (looper != 0)
				{
					for (int i = 0; i < looper; i++)
					{
						level3Stars[i].SetActive(true);
					}
				}

				break;

			case 3:

				if (looper != 0)
				{
					for (int i = 0; i < looper; i++)
					{
						level4Stars[i].SetActive(true);
					}
				}

				break;

			case 4:

				if (looper != 0)
				{
					for (int i = 0; i < looper; i++)
					{
						level5Stars[i].SetActive(true);
					}
				}

				break;


		}

	}

	public void DeactivateStars()
	{

		for (int i = 0; i < level1Stars.Length; i++)
		{
			level1Stars[i].SetActive(false);
			level2Stars[i].SetActive(false);
			level3Stars[i].SetActive(false);
			level4Stars[i].SetActive(false);
			level5Stars[i].SetActive(false);
		}

	}

	void GetStars()
	{

		game1PuzzleLevelStars = puzzleGameSaver.game1PuzzleLevelStars;
        game2PuzzleLevelStars = puzzleGameSaver.game2PuzzleLevelStars;
        game3PuzzleLevelStars = puzzleGameSaver.game3PuzzleLevelStars;

	}
}
