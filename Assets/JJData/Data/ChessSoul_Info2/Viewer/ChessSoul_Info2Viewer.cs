using UnityEngine;




public  class ChessSoul_Info2Viewer : MonoBehaviour
{
    public ChessSoul_Info2_ChessSoul[] ChessSoulDataViewer;
    void Start()
    {
        ChessSoulDataViewer = ChessSoul_Info2.ChessSoul;
    }
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void CreateViewer()
    {
        GameObject viewer = new GameObject($"ChessSoul_Info2Viewer");
        viewer.AddComponent<ChessSoul_Info2Viewer>();
        GameObject.DontDestroyOnLoad(viewer);
    }
}
