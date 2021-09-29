
using TMPro;
using UnityEngine;

public class PPFeeding : DataFeeder
{
    [SerializeField] SpriteRenderer leftBox;
    [SerializeField] SpriteRenderer rightBox;
    [SerializeField] SpriteRenderer cardBox;
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
        if (currentQuestion.data!= null)
        {
             randomQuestion = questionList.GetRandom();

            cardBox.sprite = currentQuestion.data.Img;
            if (Random.Range(1, 10) > 5)
            {
                leftBox.sprite = currentQuestion.data.Img;
                rightBox.sprite = randomQuestion.Img;
                leftText.text = currentQuestion.data.Word;
                rightText.text = randomQuestion.Word;
                currentQuestion.tag = CurrentQuestion.left;
            }
            else
            {
                rightBox.sprite = currentQuestion.data.Img;
                leftBox.sprite = randomQuestion.Img;
                rightText.text = currentQuestion.data.Word;
                leftText.text = randomQuestion.Word;
                currentQuestion.tag = CurrentQuestion.right;
            }


        }
    }

}
