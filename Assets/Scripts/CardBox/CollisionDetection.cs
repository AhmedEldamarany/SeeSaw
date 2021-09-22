using System.Collections;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] CurrentQuestion CurrentQuestion;
    [SerializeField] LevelRotating LevelThatRotates;
    [SerializeField] DataFeeder feedTheData;
    [SerializeField] SFX sfx;
    [SerializeField] ButtonNarrator buttonNarrator;
    [SerializeField] SeeSawFeedback seeSawColorFeedback;
    [SerializeField] SideBoxGenerator sideBoxGenerator;

    bool isOnce = true;
    Pooling pooling;

    private void Start()
    {
        pooling = GetComponent<Pooling>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 && isOnce)
        {
            isOnce = false;
            pooling.ResetOrientation();
            if (collision.gameObject.CompareTag(CurrentQuestion.tag))
            {
                sfx.playWin(true);
                seeSawColorFeedback.SetColorFeedBack(true);
                sideBoxGenerator.CloseTheCurrentBox();
            }
            else
            {
                sfx.playWin(false);
                seeSawColorFeedback.SetColorFeedBack(false);

            }

            StartCoroutine("LoadNewQuestion");

        }
    }

    IEnumerator LoadNewQuestion()
    {
        do
        {
            LevelThatRotates.ResetRotation();
            yield return null;

        }
        while (sfx.IsPlaying());

        buttonNarrator.PlayCurrentWord();
        do
        {
            LevelThatRotates.ResetRotation();
            yield return null;

        }
        while (buttonNarrator.IsPlaying());


        seeSawColorFeedback.ResetColor();
        pooling.StartOver();
        feedTheData.ChangeQuestion();
        isOnce = true;
        yield return new WaitForEndOfFrame();
    }

}
