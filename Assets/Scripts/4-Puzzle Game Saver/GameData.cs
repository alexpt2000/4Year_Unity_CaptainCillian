using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

[SerializeField]
public class GameData
{

	private bool[] candyPuzzleLevels;
	private bool[] transportPuzzleLevels;
	private bool[] fruitPuzzlePuzzleLevels;

	private int[] candyPuzzleLevelStars;
	private int[] transportPuzzleLevelStars;
	private int[] fruitPuzzleLevelStars;

	private bool isGameStartedForTheFirstTime;

	private float musicVolume;


	public void SetCandyPuzzleLevels(bool[] candyPuzzleLevels)
	{
		this.candyPuzzleLevels = candyPuzzleLevels;
	}

	public bool[] GetCandyPuzzleLevels()
	{
		return candyPuzzleLevels;
	}

	public void SetTransportPuzzleLevels(bool[] transportPuzzleLevels)
	{
		this.transportPuzzleLevels = transportPuzzleLevels;
	}

	public bool[] GetTransportPuzzleLevels()
	{
		return transportPuzzleLevels;
	}

	public void SetFruitPuzzlePuzzleLevels(bool[] fruitPuzzlePuzzleLevels)
	{
		this.fruitPuzzlePuzzleLevels = fruitPuzzlePuzzleLevels;
	}

	public bool[] GetFruitPuzzlePuzzleLevels()
	{
		return fruitPuzzlePuzzleLevels;
	}


	public void SetCandyPuzzleLevelStars(int[] candyPuzzleLevelStars)
	{
		this.candyPuzzleLevelStars = candyPuzzleLevelStars;
	}

	public int[] GetCandyPuzzleLevelStars()
	{
		return candyPuzzleLevelStars;
	}


	public void SetTransportPuzzleLevelStars(int[] transportPuzzleLevelStars)
	{
		this.transportPuzzleLevelStars = transportPuzzleLevelStars;
	}

	public int[] GetTransportPuzzleLevelStars()
	{
		return transportPuzzleLevelStars;
	}

	public void SetFruitPuzzleLevelStars(int[] fruitPuzzleLevelStars)
	{
		this.fruitPuzzleLevelStars = fruitPuzzleLevelStars;
	}

	public int[] GetFruitPuzzleLevelStars()
	{
		return fruitPuzzleLevelStars;
	}



	public void SetIsGameStartedForTheFirstTime(bool isGameStartedForTheFirstTime)
	{
		this.isGameStartedForTheFirstTime = isGameStartedForTheFirstTime;
	}

	public bool GetIsGameStartedForTheFirstTime()
	{
		return isGameStartedForTheFirstTime;
	}



	public void SetMusicVolume(float musicVolume)
	{
		this.musicVolume = musicVolume;
	}

	public float GetMusicVolume()
	{
		return musicVolume;
	}
}
