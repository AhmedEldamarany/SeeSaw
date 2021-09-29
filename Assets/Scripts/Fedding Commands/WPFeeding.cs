using TMPro;
using UnityEngine;


public class WPFeeding : DataFeeder
{
    [SerializeField] SpriteRenderer leftImage;
    [SerializeField] SpriteRenderer rightImage;
    [SerializeField] TMP_Text cardBox;
    [SerializeField] TMP_Text leftText;
    [SerializeField] TMP_Text rightText;
    QuestionSO randomQuestion;
    void Start()
    {
        Feed();
    }

    protected override void Feed()
    {
        base.Feed();
        if (currentQuestion.data != null)
        {
             randomQuestion = questionList.GetRandom();
            cardBox.text = currentQuestion.data.Word;
            if (Random.Range(1, 10) > 5)
            {
                leftImage.sprite = currentQuestion.data.Img;
                rightImage.sprite =randomQuestion.Img;
                leftText.text = currentQuestion.data.Word;
                rightText.text = randomQuestion.Word;
                currentQuestion.tag = CurrentQuestion.left;
            }
            else
            {
                rightImage.sprite = currentQuestion.data.Img;
                leftImage .sprite= randomQuestion.Img;
                rightText.text = currentQuestion.data.Word;
                leftText.text = randomQuestion.Word;
                currentQuestion.tag = CurrentQuestion.right;
            }


        }
    }
}
