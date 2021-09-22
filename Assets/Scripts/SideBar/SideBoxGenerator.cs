using UnityEngine;

public class SideBoxGenerator : MonoBehaviour
{
    int numberOfBoxes;
    [SerializeField] GameObject BoxPrefab;
    [HideInInspector] public QuestionList questionList;
    SpriteRenderer[] Boxes;
    [SerializeField] Sprite ClosedBox;
    void Start()
    {
        numberOfBoxes = questionList.Count();
        Boxes = new SpriteRenderer[numberOfBoxes];
        if (numberOfBoxes > 10)
            Debug.LogWarning("Side bar's max capcity is 10 boxes");
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject go = Instantiate(BoxPrefab, transform, false);
            go.transform.localPosition = new Vector3(0, -i * .7f, 0);
            Boxes[i] = go.GetComponent<SpriteRenderer>();
        }
    }

    public void CloseTheCurrentBox()
    {
        Boxes[questionList.index].sprite = ClosedBox;
    }
}
