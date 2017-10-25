﻿using NUnit.Framework;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

{
    public class TextureCacheCounter : TextureCache
    {
        public int transferToSliceCallCount { get; private set; }

        {
            AllocTextureArray(8);
        }

        {
            ++transferToSliceCallCount;
        }
    }

    [TestFixture]
    public class TextureCacheTests
    {
        Texture2D m_Tex;
        const int k_TextureSize = 8;
        static readonly Color[] s_Pixels = new Color[k_TextureSize * k_TextureSize];
        
        public void Setup()
        {
            m_Tex = new Texture2D(k_TextureSize, k_TextureSize, TextureFormat.ARGB32, false, true);

            SetTextureColor(Color.blue);

        [Test]
        public void TextureCacheAddSlice()
        {
            var cache = new TextureCacheCounter();


            Assert.True(slice >= 0);
            Assert.AreEqual(1, cache.transferToSliceCallCount);

            var slice2 = cache.FetchSlice(m_Tex);

            Assert.AreEqual(slice, slice2);
            Assert.AreEqual(1, cache.transferToSliceCallCount);

            SetTextureColor(Color.red);

            var slice3 = cache.FetchSlice(m_Tex);

            Assert.AreEqual(slice, slice3);
            Assert.AreEqual(2, cache.transferToSliceCallCount);

        {
            for (var i = 0; i < s_Pixels.Length; ++i)
                s_Pixels[i] = Color.blue;

            m_Tex.Apply();
        }
    }
}
