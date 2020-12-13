using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTransition : MonoBehaviour
{
    public void SceneTranstion()
    {
        List<GameObject> list = new List<GameObject>();
        SceneTransitionManager.Instance.GoToScene(MysoreGoConstant.SCENE_AR, list);

    }
}
