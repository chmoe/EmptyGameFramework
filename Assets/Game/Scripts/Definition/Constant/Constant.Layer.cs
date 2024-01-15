using UnityEngine;

public static partial class Constant
{
    /// <summary>
    /// 层。
    /// </summary>
    public static class Layer
    {
        public const string DefaultLayerName = "Default";
        public static readonly int DefaultLayerId = LayerMask.NameToLayer(DefaultLayerName);

        public const string UILayerName = "UI";
        public static readonly int UILayerId = LayerMask.NameToLayer(UILayerName);

        public const string BuildingLayerName = "Building";
        public static readonly int BuildingLayerId = LayerMask.NameToLayer(BuildingLayerName);
        public static readonly int BuildingLayer = LayerMask.GetMask(BuildingLayerName);

        public const string GroundLayerName = "Ground";
        public static readonly int GroundLayerId = LayerMask.NameToLayer(GroundLayerName);
        public static readonly int GroundLayer = LayerMask.GetMask(GroundLayerName);

        public const string CameraFollowPointLayerName = "CameraFollowPoint";
        public static readonly int CameraFollowPointLayerId = LayerMask.NameToLayer(CameraFollowPointLayerName);
        public static readonly int CameraFollowPointLayer = LayerMask.GetMask(CameraFollowPointLayerName);
    }
}
