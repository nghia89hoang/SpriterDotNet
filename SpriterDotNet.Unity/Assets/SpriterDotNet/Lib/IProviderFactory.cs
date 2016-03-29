﻿// Copyright (c) 2015 The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

namespace SpriterDotNet
{
    public interface IProviderFactory<TSprite, TSound>
    {
        IAssetProvider<TSprite> GetSpriteProvider(SpriterEntity spriter);
        IAssetProvider<TSound> GetSoundProvider(SpriterEntity spriter);
        IAnimationDataProvider GetDataProvider(SpriterEntity spriter);
    }
}