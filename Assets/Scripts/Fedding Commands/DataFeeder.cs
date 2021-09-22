
using TMPro;
using UnityEngine;

public class DataFeeder : MonoBehaviour
{
    [SerializeField]protected CurrentQuestion currentQuestion;
    [SerializeField] protected QuestionList questionList;
    [SerializeField] SideBoxGenerator sideBoxGenerator;
    
    
    [SerializeField] TMP_Text overHeadText;
   
    public void ChangeQuestion()
    {
        questionList.MoveForward();
        Feed();
    }
    private void Awake()
    {
        sideBoxGenerator.questionList = questionList;
    }
    protected virtual void Feed()
    {
        currentQuestion.data = questionList.GetCurrent();
        if (currentQuestion.data != null)
        {
            overHeadText.text = currentQuestion.data.Word;
            currentQuestion.tag = CurrentQuestion.left;

        }
        else
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
   
}
