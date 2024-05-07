using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class Mgr_Anim : MonoBehaviour
{

    public Animator Ator = null;

    public Transform RootBtns = null;

    public Button[] Btns = null;


    public SkinnedMeshRenderer SkinRen = null;

    public Transform RootSds = null;
    public Slider[] Sds = null;
    public Text[] Txs = null;
    List<string> BlendShapeNames = new List<string>();


    Dictionary<string, int> BlendShapeDatabase = new Dictionary<string, int>();

    public Button BtnAnimation= null;
    public Button BtnBlendShapes= null;

    public GameObject CamAnim = null;
    public GameObject CamBlendShapes = null;

    private void Start()
    {
        
        Btns = RootBtns.GetComponentsInChildren<Button>();

      
        for (int i = 0; i < Btns.Length; i++)
        {
            string _strAnim = Btns[i].name;

            Btns[i].onClick.AddListener(
                    delegate () {
                        Ator.SetTrigger(_strAnim);
                    }
                );
        }

        IniBlendShapes();

        Sds = RootSds.GetComponentsInChildren<Slider>();
        Txs = RootSds.GetComponentsInChildren<Text>();
        for (int i = 0; i < Sds.Length; i++)
        {
            string _nm = BlendShapeNames[i];

            Txs[i].text = _nm;
            Sds[i].onValueChanged.AddListener(value => ChangeBlendShapeValue(_nm, value));
        }

        BtnAnimation.onClick.AddListener(
                delegate () {
                    if (RootBtns.gameObject.activeSelf)
                    {
                        RootBtns.gameObject.SetActive(false);
                        
                    }
                    else if (RootSds.gameObject.activeSelf)
                    {
                        RootBtns.gameObject.SetActive(true);
                        RootSds.gameObject.SetActive(false);
                        CamAnim.SetActive(true);
                        CamBlendShapes.SetActive(false);
                    }
                    else
                    {
                        RootBtns.gameObject.SetActive(true);
                        CamAnim.SetActive(true);
                        CamBlendShapes.SetActive(false);
                    }
                }
            );

        BtnBlendShapes.onClick.AddListener(
               delegate () {
                   if (RootSds.gameObject.activeSelf)
                   {
                       RootSds.gameObject.SetActive(false);
                   }
                   else if (RootBtns.gameObject.activeSelf)
                   {
                       RootBtns.gameObject.SetActive(false);
                       RootSds.gameObject.SetActive(true);
                       CamAnim.SetActive(false);
                       CamBlendShapes.SetActive(true);
                   }
                   else
                   {
                       RootSds.gameObject.SetActive(true);
                       CamAnim.SetActive(false);
                       CamBlendShapes.SetActive(true);
                   }
               }
           );
    }



    private void IniBlendShapes()
    {
        BlendShapeNames = Enumerable.Range(0, SkinRen.sharedMesh.blendShapeCount).Select(x => SkinRen.sharedMesh.GetBlendShapeName(x)).ToList();



        for (int i = 0; i < BlendShapeNames.Count; i++)
        {
            int _index = i;
            string _nm= BlendShapeNames[i];
            BlendShapeDatabase.Add(_nm, _index);
        }         
    }

    public void ChangeBlendShapeValue(string blendShapeName, float value)
    {

        int _index = BlendShapeDatabase[blendShapeName];

        SkinRen.SetBlendShapeWeight(_index, value);

        return;      
    }

}



/// <summary>
/// BlendShapesIndex
/// ´æ´¢Ë÷Òý
/// </summary>
public class BlendShapeIndex
{

    public int postiveIndex { get; set; }
    public int negativeIndex { get; set; }

    public BlendShapeIndex(int postiveIndex, int negativeIndex)
    {
        this.postiveIndex = postiveIndex;
        this.negativeIndex = negativeIndex;
    }

}
