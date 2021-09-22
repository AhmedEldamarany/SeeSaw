using TMPro;
using UnityEngine;


public class PWFeeding : DataFeeder
{
    [SerializeField] SpriteRenderer leftImage;
    [SerializeField] SpriteRenderer rightImage;
    [SerializeField] TMP_Text cardBox;

    void Start()
    {
        Feed();
    }

    protected override void Feed()
    {
        base.Feed();
        if (currentQuestion.data != null)
        {
            cardBox.text = currentQuestion.data.Word;
            if (Random.Range(1, 10) > 5)
            {
                leftImage.sprite = currentQuestion.data.Img;
                rightImage.sprite = questionList.GetRandom().Img;
                currentQuestion.tag = CurrentQuestion.left;
            }
            else
            {
                rightImage.sprite = currentQuestion.data.Img;
                leftImage .sprite= questionList.GetRandom().Img;
                currentQuestion.tag = CurrentQuestion.right;
            }


        }
    }
}
