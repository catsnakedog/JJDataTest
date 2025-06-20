using UnityEngine;




public  class ChessSoul_InfoViewer : MonoBehaviour
{
    public ChessSoul_Info_ChessSoul[] ChessSoulDataViewer;
    void Start()
    {
        ChessSoulDataViewer = ChessSoul_Info.ChessSoul;
    }
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void CreateViewer()
    {
        GameObject viewer = new GameObject($"ChessSoul_InfoViewer");
        viewer.AddComponent<ChessSoul_InfoViewer>();
        GameObject.DontDestroyOnLoad(viewer);
    }
}
