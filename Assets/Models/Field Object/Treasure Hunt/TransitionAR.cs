using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAR : MonoBehaviour
{
    [SerializeField] private int bonus = 100;

    private void OnMouseDown()
    {
        GameManager.Instance.CurrentPlayer.AddXp(bonus);

        List < GameObject > list = new List<GameObject>();
        list.Add(gameObject);

        SceneTransitionManager.Instance.GoToScene(MysoreGoConstant.SCENE_AR, list);
        Destroy(gameObject);
    }
}
