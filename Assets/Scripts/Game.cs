using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject title;
    [SerializeField] GameObject firstText;
    [SerializeField] GameObject secondText;
    [SerializeField] GameObject thirdText;
    [SerializeField] GameObject numberText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        numberText.SetActive(true);
    }

    public void Gameplay()
    {

    }
}
