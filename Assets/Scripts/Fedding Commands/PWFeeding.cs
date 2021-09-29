
using UnityEngine;
using TMPro;


public class PWFeeding : DataFeeder
{
    [SerializeField] TMP_Text leftText;
    [SerializeField] TMP_Text rightText;
    [SerializeField] SpriteRenderer cardBox;

    void Start()
    {
        Feed();
    }

    protected override void Feed()
    {
        base.Feed();
        if(currentQuestion.data!=null)
        {
            cardBox.sprite = currentQuestion.data.Img;
            if(Random.Range(1,10)>5)
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
