using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject title;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject firstText;
    [SerializeField] GameObject secondText;
    [SerializeField] GameObject thirdText;
    [SerializeField] TextMeshProUGUI number;
    [SerializeField] GameObject gameplay;
    [SerializeField] GameObject end;
    [SerializeField] TextMeshProUGUI endAttempts;
    [SerializeField] TextMeshProUGUI endNumber;

    int smallestPossible, biggestPossible, attempts;

    int guess;

    public int Guess
    {
        get => guess;

        set
        {
            guess = value;
            number.text = guess.ToString();
        }
    }

    public void StartGame()
    {
        end.SetActive(false);
        title.SetActive(false);
        startButton.SetActive(false);
        firstText.SetActive(true);

        Guess = Random.Range(1, 1001);
        attempts = 1;
        smallestPossible = 1;
        biggestPossible = 1000;
    }

    public void First()
    {
        firstText.SetActive(false);
        secondText.SetActive(true);
    }

    public void Second()
    {
        secondText.SetActive(false);
        thirdText.SetActive(true);
    }

    public void Third()
    {
        thirdText.SetActive(false);
        gameplay.SetActive(true);
    }

    public void TooSmall()
    {
        smallestPossible = Guess + 1;
        Guess = RandomNewPossible();
        attempts++;
    }

    public void TooBig()
    {
        biggestPossible = Guess - 1;
        Guess = RandomNewPossible();
        attempts++;
    }

    public void CorrectNumber()
    {
        endNumber.text = guess.ToString();
        endAttempts.text = attempts.ToString();
        end.SetActive(true);
        gameplay.SetActive(false);
        startButton.SetActive(true);
    }

    int RandomNewPossible()
    {
        return Random.Range(smallestPossible, biggestPossible + 1);
    }
}
