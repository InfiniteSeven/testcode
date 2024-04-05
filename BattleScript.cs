using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Collections;
using JetBrains.Annotations;
public class BattleScript : MonoBehaviour
{
    public TextMeshProUGUI blueoutput;
    public TextMeshProUGUI redoutput;
    public TextMeshProUGUI defoutput;
    public TextMeshProUGUI bluecas1;
    public TextMeshProUGUI bluecas2;
    public TextMeshProUGUI bluecas3;
    public TextMeshProUGUI redcas1;
    public TextMeshProUGUI redcas2;
    public TextMeshProUGUI redcas3;
    [SerializeField] private GameObject bluePanel;
    [SerializeField] private GameObject redPanel;

    // Start is called before the first frame update
    // Update is called once per frame
    public void BattleCalculation()
    {

        float bluetype1 = (bluePanel.GetComponent<BluePanelScript>().Type_1.value);
        int bluemanpower1 = int.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_1.text);
        int blueskill1 = (bluePanel.GetComponent<BluePanelScript>().Skill_1.value);
        float blueterrain1 = (redPanel.GetComponent<RedPanelScript>().Terrain_1.value);
        float orders1 = (bluePanel.GetComponent<BluePanelScript>().Orders_1.value);


        float bluetype2 = (bluePanel.GetComponent<BluePanelScript>().Type_2.value);
        int bluemanpower2 = int.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_2.text);
        int blueskill2 = (bluePanel.GetComponent<BluePanelScript>().Skill_2.value);
        float blueterrain2 = (redPanel.GetComponent<RedPanelScript>().Terrain_2.value);


        float bluetype3 = (bluePanel.GetComponent<BluePanelScript>().Type_3.value);
        int bluemanpower3 = int.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_3.text);
        int blueskill3 = (bluePanel.GetComponent<BluePanelScript>().Skill_3.value);
        float blueterrain3 = (redPanel.GetComponent<RedPanelScript>().Terrain_3.value);

        float bluedefense1 = blueterrain1;
        switch (bluedefense1)
        {
            case 0:
                bluedefense1 = 0;
                break;
            case 1:
                bluedefense1 = 1;
                break;
            case 2:
                bluedefense1 = 0.85f;
                break;
            case 3:
                bluedefense1 = 0.80f;
                break;
            case 4:
                bluedefense1 = 0.75f;
                break;
            case 5:
                bluedefense1 = 0.70f;
                break;
            case 6:
                bluedefense1 = 0.60f;
                break;
            case 7:
                bluedefense1 = 0.50f;
                break;
        }

        float bluedefense2 = blueterrain2;
        switch (bluedefense2)
        {
            case 0:
                bluedefense2 = 0;
                break;
            case 1:
                bluedefense2 = 1;
                break;
            case 2:
                bluedefense2 = 0.85f;
                break;
            case 3:
                bluedefense2 = 0.80f;
                break;
            case 4:
                bluedefense2 = 0.75f;
                break;
            case 5:
                bluedefense2 = 0.70f;
                break;
            case 6:
                bluedefense2 = 0.60f;
                break;
            case 7:
                bluedefense2 = 0.50f;
                break;
        }

        float bluedefense3 = blueterrain3;
        switch (bluedefense3)
        {
            case 0:
                bluedefense3 = 0;
                break;
            case 1:
                bluedefense3 = 1;
                break;
            case 2:
                bluedefense3 = 0.85f;
                break;
            case 3:
                bluedefense3 = 0.80f;
                break;
            case 4:
                bluedefense3 = 0.75f;
                break;
            case 5:
                bluedefense3 = 0.70f;
                break;
            case 6:
                bluedefense3 = 0.60f;
                break;
            case 7:
                bluedefense3 = 0.50f;
                break;
        }


        float redtype1 = (redPanel.GetComponent<RedPanelScript>().Type_1.value);
        int redmanpower1 = int.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_1.text);
        int redskill1 = (redPanel.GetComponent<RedPanelScript>().Skill_1.value);
        float redterrain1 = (bluePanel.GetComponent<BluePanelScript>().Terrain_1.value);

        float redtype2 = (redPanel.GetComponent<RedPanelScript>().Type_2.value);
        int redmanpower2 = int.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_2.text);
        int redskill2 = (redPanel.GetComponent<RedPanelScript>().Skill_2.value);
        float redterrain2 = (bluePanel.GetComponent<BluePanelScript>().Terrain_2.value);

        float redtype3 = (redPanel.GetComponent<RedPanelScript>().Type_3.value);
        int redmanpower3 = int.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_3.text);
        int redskill3 = (redPanel.GetComponent<RedPanelScript>().Skill_3.value);
        float redterrain3 = (bluePanel.GetComponent<BluePanelScript>().Terrain_3.value);

        float reddefense1 = redterrain1;
        switch (reddefense1)
        {
            case 0:
                reddefense1 = 0;
                break;
            case 1:
                reddefense1 = 1;
                break;
            case 2:
                reddefense1 = 0.85f;
                break;
            case 3:
                reddefense1 = 0.80f;
                break;
            case 4:
                reddefense1 = 0.75f;
                break;
            case 5:
                reddefense1 = 0.70f;
                break;
            case 6:
                reddefense1 = 0.60f;
                break;
            case 7:
                reddefense1 = 0.50f;
                break;
        }

        float reddefense2 = redterrain2;
        switch (reddefense2)
        {
            case 0:
                reddefense2 = 0;
                break;
            case 1:
                reddefense2 = 1;
                break;
            case 2:
                reddefense2 = 0.85f;
                break;
            case 3:
                reddefense2 = 0.80f;
                break;
            case 4:
                reddefense2 = 0.75f;
                break;
            case 5:
                reddefense2 = 0.70f;
                break;
            case 6:
                reddefense2 = 0.60f;
                break;
            case 7:
                reddefense2 = 0.50f;
                break;
        }

        float reddefense3 = redterrain3;
        switch (reddefense3)
        {
            case 0:
                reddefense3 = 0;
                break;
            case 1:
                reddefense3 = 1;
                break;
            case 2:
                reddefense3 = 0.85f;
                break;
            case 3:
                reddefense3 = 0.80f;
                break;
            case 4:
                reddefense3 = 0.75f;
                break;
            case 5:
                reddefense3 = 0.70f;
                break;
            case 6:
                reddefense3 = 0.60f;
                break;
            case 7:
                reddefense3 = 0.50f;
                break;
        }

        int[] bluearray1 = new int[] {
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1),
        UnityEngine.Random.Range(0, bluemanpower1) };
        Array.Sort(bluearray1);
        int blueresult1 = bluearray1[blueskill1 - 1];

        int[] bluearray2 = new int[] {
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2),
        UnityEngine.Random.Range(0, bluemanpower2) };
        Array.Sort(bluearray2);
        int blueresult2 = bluearray2[blueskill2 - 1];

        int[] bluearray3 = new int[] {
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3),
        UnityEngine.Random.Range(0, bluemanpower3) };
        Array.Sort(bluearray3);
        int blueresult3 = bluearray3[blueskill3 - 1];

        float bluekillpower1 = blueresult1 * (3 / bluetype1);
        float bluekillpower2 = blueresult2 * (3 / bluetype2);
        float bluekillpower3 = blueresult3 * (3 / bluetype3);

        float totalbluekills = (bluekillpower1 + bluekillpower2 + bluekillpower3);

        float reddeaths1 = Mathf.RoundToInt(UnityEngine.Random.Range(0, totalbluekills * (redtype1 / reddefense1)));
        float reddeaths2 = Mathf.RoundToInt(UnityEngine.Random.Range(0, (totalbluekills - reddeaths1)) * (redtype2 / reddefense2));
        float reddeaths3 = Mathf.RoundToInt(UnityEngine.Random.Range(0, (totalbluekills - (reddeaths1 + reddeaths2))) * (redtype3 * reddefense3));

        string redcasualties1 = reddeaths1.ToString();
        redcas1.text = redcasualties1;
        string redcasualties2 = reddeaths2.ToString();
        redcas2.text = redcasualties2;
        string redcasualties3 = reddeaths3.ToString();
        redcas3.text = redcasualties3;

        int[] redarray1 = new int[] {
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1),
        UnityEngine.Random.Range(0, redmanpower1) };
        Array.Sort(redarray1);
        int redresult1 = redarray1[redskill1 - 1];

        int[] redarray2 = new int[] {
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2),
        UnityEngine.Random.Range(0, redmanpower2) };
        Array.Sort(redarray2);
        int redresult2 = redarray2[redskill2 - 1];

        int[] redarray3 = new int[] {
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3),
        UnityEngine.Random.Range(0, redmanpower3) };
        Array.Sort(redarray3);
        int redresult3 = redarray3[redskill3 - 1];

        float redkillpower1 = redresult1 * (3 / bluetype1);
        float redkillpower2 = redresult2 * (3 / bluetype2);
        float redkillpower3 = redresult3 * (3 / bluetype3);

        float totalredkills = (redkillpower1 + redkillpower2 + redkillpower3);

        float bluedeaths1 = Mathf.RoundToInt(UnityEngine.Random.Range(0, totalredkills) * (bluetype1 / bluedefense1));
        float bluedeaths2 = Mathf.RoundToInt(UnityEngine.Random.Range(0, (totalredkills - bluedeaths1)) * (bluetype2 / bluedefense2));
        float bluedeaths3 = Mathf.RoundToInt(UnityEngine.Random.Range(0, (totalredkills - (bluedeaths1+bluedeaths2))) * (bluetype3*bluedefense3));

        string bluecasualties1 = bluedeaths1.ToString();
        bluecas1.text = bluecasualties1;
        string bluecasualties2 = bluedeaths2.ToString();
        bluecas2.text = bluecasualties2;
        string bluecasualties3 = bluedeaths3.ToString();
        bluecas3.text = bluecasualties3;
    }
    public void Startingnumbers()
    {
        float bluemanpower1 = float.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_1.text);
        float bluemanpower2 = float.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_2.text);
        float bluemanpower3 = float.Parse(bluePanel.GetComponent<BluePanelScript>().Manpower_3.text);

        float redmanpower1 = float.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_1.text);
        float redmanpower2 = float.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_2.text);
        float redmanpower3 = float.Parse(redPanel.GetComponent<RedPanelScript>().Manpower_3.text);

        string bluestartingmanpower = (bluemanpower1 + bluemanpower2 + bluemanpower3).ToString();
        blueoutput.text = bluestartingmanpower;

        string redstartingmanpower = (redmanpower1 + redmanpower2 + redmanpower3).ToString();
        redoutput.text = redstartingmanpower;

        float bluemorale1 = (bluePanel.GetComponent<BluePanelScript>().Morale_1.value);
        float bluediscipline1 = (bluePanel.GetComponent<BluePanelScript>().Discipline_1.value);
        float bluemorale2 = (bluePanel.GetComponent<BluePanelScript>().Morale_2.value);
        float bluediscipline2 = (bluePanel.GetComponent<BluePanelScript>().Discipline_2.value);
        float bluemorale3 = (bluePanel.GetComponent<BluePanelScript>().Morale_3.value);
        float bluediscipline3 = (bluePanel.GetComponent<BluePanelScript>().Discipline_3.value);

        float redmorale1 = (redPanel.GetComponent<RedPanelScript>().Morale_1.value);
        float reddiscipline1 = (redPanel.GetComponent<RedPanelScript>().Discipline_1.value);
        float redmorale2 = (redPanel.GetComponent<RedPanelScript>().Morale_2.value);
        float reddiscipline2 = (redPanel.GetComponent<RedPanelScript>().Discipline_2.value);
        float redmorale3 = (redPanel.GetComponent<RedPanelScript>().Morale_3.value);
        float reddiscipline3 = (redPanel.GetComponent<RedPanelScript>().Discipline_3.value);

        float blueretreat1 = (Mathf.Max(bluemorale1, bluediscipline1)) / 10;
        float blueretreat2 = (Mathf.Max(bluemorale2, bluediscipline2)) / 10;
        float blueretreat3 = (Mathf.Max(bluemorale3, bluediscipline3)) / 10;

        float redretreat1 = (Mathf.Max(redmorale1, reddiscipline1)) / 10;
        float redretreat2 = (Mathf.Max(redmorale2, reddiscipline2)) / 10;
        float redretreat3 = (Mathf.Max(redmorale3, reddiscipline3)) / 10;


    }


}
