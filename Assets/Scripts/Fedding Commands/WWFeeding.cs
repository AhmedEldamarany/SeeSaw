using TMPro;
using UnityEngine;

public class WWFeeding : DataFeeder
{
    [SerializeField] TMP_Text leftText;
    [SerializeField] TMP_Text rightText;
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
                leftText.text = currentQuestion.data.Word;
                rightText.text = questionList.GetRandom().Word;
                currentQuestion.tag = CurrentQuestion.left;
            }
            else
            {
                rightText.text = currentQuestion.data.Word;
                leftText.text = questionList.GetRandom().Word;
                currentQuestion.tag = CurrentQuestion.right;
            }


        }
    }
}
