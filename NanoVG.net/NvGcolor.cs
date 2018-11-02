namespace NanoVGDotNet
{
    public struct NvGcolor
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public override string ToString()
        {
            return $"[NVGcolor: r={R}, g={G}, b={B}, a={A}]";
        }
    }
}