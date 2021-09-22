using System.Xml;
using UnityEngine;

public class XmlExtractor : MonoBehaviour
{
    [SerializeField] TextAsset XmlFile;
    [SerializeField] QuestionList newQuestionList;

    void Start()
    {
        string xmlData = XmlFile.text;
        ParseXML(xmlData);
    }

    private void ParseXML(string xmlData)
    {
        XmlDocument document = new XmlDocument();
        document.LoadXml(xmlData);
        XmlNodeList questionList = document.ChildNodes[0].ChildNodes[0].ChildNodes;
        XmlNodeList xmlElement = document.DocumentElement.GetElementsByTagName("question"); //same as line above
        newQuestionList.init(questionList.Count);
        foreach (XmlElement question in questionList)
        {
            newQuestionList.Add(question.Attributes[2].Value, question.Attributes[0].Value, question.Attributes[1].Value);
        }
    }
}
