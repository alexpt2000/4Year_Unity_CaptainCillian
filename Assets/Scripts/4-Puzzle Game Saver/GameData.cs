using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GameData
{

	private bool[] game1PuzzleLevels;
    private bool[] game2PuzzleLevels;
	private bool[] game3PuzzleLevels;

	private int[] game1PuzzleLevelStars;
	private int[] game2PuzzleLevelStars;
	private int[] game3PuzzleLevelStars;

	private bool isGameStartedForTheFirstTime;

	private float musicVolume;


	public void SetGame1PuzzleLevels(bool[] game1PuzzleLevels)
	{
		this.game1PuzzleLevels = game1PuzzleLevels;
	}

	public bool[] GetGame1PuzzleLevels()
	{
		return game1PuzzleLevels;
	}

	public void SetGame2PuzzleLevels(bool[] game2PuzzleLevels)
	{
        this.game2PuzzleLevels = game2PuzzleLevels;
	}

	public bool[] GetGame2PuzzleLevels()
	{
        return game2PuzzleLevels;
	}

	public void SetGame3PuzzleLevels(bool[] game3PuzzleLevels)
	{
		this.game3PuzzleLevels = game3PuzzleLevels;
	}

	public bool[] GetGame3PuzzleLevels()
	{
		return game3PuzzleLevels;
	}


	public void SetGame1PuzzleLevelStars(int[] game1PuzzleLevelStars)
	{
		this.game1PuzzleLevelStars = game1PuzzleLevelStars;
	}

	public int[] GetGame1PuzzleLevelStars()
	{
		return game1PuzzleLevelStars;
	}


	public void SetGame2PuzzleLevelStars(int[] game2PuzzleLevelStars)
	{
		this.game2PuzzleLevelStars = game2PuzzleLevelStars;
	}

	public int[] GetGame2PuzzleLevelStars()
	{
		return game2PuzzleLevelStars;
	}

	public void SetGame3PuzzleLevelStars(int[] game3PuzzleLevelStars)
	{
		this.game3PuzzleLevelStars = game3PuzzleLevelStars;
	}

	public int[] GetGame3PuzzleLevelStars()
	{
		return game3PuzzleLevelStars;
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
