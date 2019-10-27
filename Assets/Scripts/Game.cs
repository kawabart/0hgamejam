using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject title;
    [SerializeField] GameObject firstText;
    [SerializeField] GameObject secondText;
    [SerializeField] GameObject thirdText;
    [SerializeField] GameObject numberQuestion;
    [SerializeField] TextMeshProUGUI number;
    [SerializeField] GameObject tooSmallButton;
    [SerializeField] GameObject myNumberButton;
    [SerializeField] GameObject tooBigButton;

    int guess;
    int smallestPossible = 1, biggestPossible = 1000;

    public int Guess
    {
        get => guess;

        set
        {
            guess = value;
            number.text = guess.ToString();
        }
    }

    void Start()
    {
        Guess = Random.Range(1, 1001);
    }

    public void StartGame()
    {
        title.SetActive(false);
        firstText.SetActive(true);
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
        numberQuestion.SetActive(true);
        tooSmallButton.SetActive(true);
        myNumberButton.SetActive(true);
        tooBigButton.SetActive(true);
    }

    public void TooSmall()
    {
        smallestPossible = Guess + 1;
        Guess = RandomNewPossible();
    }

    public void TooBig()
    {
        biggestPossible = Guess - 1;
        Guess = RandomNewPossible();
    }

    public void CorrectNumber()
    {
        Debug.LogWarning("NICEOOOO");
        Debug.LogWarning(Guess);
    }

    int RandomNewPossible()
    {
        return Random.Range(smallestPossible, biggestPossible + 1);
    }
}
