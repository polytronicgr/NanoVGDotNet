namespace NanoVGDotNet
{
    public struct NvgParams
    {
        public object UserPtr;
        public int EdgeAntiAlias;
        public RenderCreateHandler RenderCreate;

        public RenderCreateTextureHandlerByte RenderCreateTexture;
        public RenderCreateTextureHandlerBmp RenderCreateTexture2;
        public RenderViewportHandler RenderViewport;
        public RenderFlushHandler RenderFlush;
        public RenderFillHandler RenderFill;
        public RenderStrokeHandler RenderStroke;
        public RenderTrianglesHandler RenderTriangles;
        public RenderUpdateTextureHandler RenderUpdateTexture;
        public RenderGetTextureSizeHandler RenderGetTextureSize;
        public RenderDeleteTexture RenderDeleteTexture;
        public RenderCancel RenderCancel;
        public RenderDelete RenderDelete;
    }
}