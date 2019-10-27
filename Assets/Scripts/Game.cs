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

    int guessNumber;

    void Start()
    {
        guessNumber = Random.Range(1, 1001);
        number.text = guessNumber.ToString();
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

    public void Gameplay()
    {
        
    }

    public void TooSmall()
    {
        
    }

    public void TooBig()
    {

    }

    public void CorrectNumber()
    {

    }
}
