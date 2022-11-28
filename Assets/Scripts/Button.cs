using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;

    private Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

    }
    /*   public void OnPointerEnter(PointerEventData eventData)
       {
           GetComponent<Button>().changeSprite(true);
       }

       public void OnPointerExit(PointerEventData eventData)
       {
           GetComponent<Button>().changeSprite(false);
       }
   */

    public void enterSprite()
    {
        image.overrideSprite = sprite2;
    }
    public void exitSprite()
    {
            image.overrideSprite = sprite1;
    }

    public void playGame()
    {
        SceneManager.LoadScene(randomSceneIndex(3));
    }

    static int randomSceneIndex(int sceneNumber)
    {
        return UnityEngine.Random.Range(1, sceneNumber);
    }
}
