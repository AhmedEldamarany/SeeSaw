
using UnityEngine;

public class PPFeeding : DataFeeder
{
    [SerializeField] SpriteRenderer leftBox;
    [SerializeField] SpriteRenderer rightBox;
    [SerializeField] SpriteRenderer cardBox;

    void Start()
    {
        Feed();
    }

    protected override void Feed()
    {
        base.Feed();
        if (currentQuestion.data!= null)
        {
            cardBox.sprite = currentQuestion.data.Img;
            if (Random.Range(1, 10) > 5)
            {
                leftBox.sprite = currentQuestion.data.Img;
                rightBox.sprite = questionList.GetRandom().Img;
                currentQuestion.tag = CurrentQuestion.left;
            }
            else
            {
                rightBox.sprite = currentQuestion.data.Img;
                leftBox.sprite = questionList.GetRandom().Img;
                currentQuestion.tag = CurrentQuestion.right;
            }


        }
    }

}
