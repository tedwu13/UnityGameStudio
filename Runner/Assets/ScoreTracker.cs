using UnityEngine;
using UnityEngine.UI;
public class ScoreTracker : MonoBehaviour {
	private int _Score;
	void Start () {
		GameObject runner = GameObject.Find("Runner");
		RunnerScript runnerScript = runner.GetComponent<RunnerScript>();
		runnerScript.LandedOnPlatform += OnSuccessfulLanding;
		runnerScript.FellIntoTheVoid += OnFellIntoTheVoid;
		UpdateScoreText();
	}
	private void OnFellIntoTheVoid () {
		GameObject scoreTextObject = this.gameObject;
		Text textComponent = scoreTextObject.GetComponent<Text>();
		textComponent.text = string.Format ("GAME OVER!");
	}
	private void OnSuccessfulLanding () {
		this._Score += 100; // 100 points per platform
		UpdateScoreText();
	}
	private void UpdateScoreText () {
		GameObject scoreTextObject = this.gameObject;
		Text textComponent = scoreTextObject.GetComponent<Text>();
		textComponent.text = string.Format("Score: {0}", _Score);
	}}