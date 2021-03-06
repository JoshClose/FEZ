﻿// Type: Microsoft.Xna.Framework.Net.NetworkMessageType
// Assembly: MonoGame.Framework, Version=3.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 69677294-4E99-4B9C-B72B-CC2D8AA03B63
// Assembly location: F:\Program Files (x86)\FEZ\MonoGame.Framework.dll

namespace Microsoft.Xna.Framework.Net
{
  internal enum NetworkMessageType : byte
  {
    Data,
    GamerJoined,
    GamerLeft,
    Introduction,
    GamerProfile,
    RequestGamerProfile,
    GamerStateChange,
    SessionStateChange,
  }
}
