using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzle : MonoBehaviour
{
    [SerializeField]
    private PuzzleGameManager puzzleGameManager;

    [SerializeField]
    private SelectLevel selectLevel;

	[SerializeField]
	private LevelLocker levelLocker;

	[SerializeField]
	private StarsLocker starLocker;

    [SerializeField]
    private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

    [SerializeField]
    private Animator selectPuzzleManuAnime, puzzleLevelSelectAnim;

    private string selectedPuzzle;

    public void SelectedPuzzle()
    {

		starLocker.DeactivateStars();

        selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        puzzleGameManager.SetSelectedPuzzle(selectedPuzzle);

		levelLocker.CheckWhichLevelsAreUnlocked(selectedPuzzle);

        selectLevel.SetSelectedPuzzle(selectedPuzzle);

        StartCoroutine(ShowPuzzleLevelSelectMenu());
    }


    IEnumerator ShowPuzzleLevelSelectMenu() {

        puzzleLevelSelectPanel.SetActive(true);
        selectPuzzleManuAnime.Play("SlideOut");
        puzzleLevelSelectAnim.Play("SlideIn");
        yield return new WaitForSeconds(1f);
        selectPuzzleMenuPanel.SetActive(false);


    }

}
