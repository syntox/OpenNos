﻿using OpenNos.Core;

namespace OpenNos.Handler
{
    [Header("walk")]
    public class WalkPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public short XCoordinate { get; set; }

        [PacketIndex(1)]
        public short YCoordinate { get; set; }

        [PacketIndex(3)]
        public short Speed { get; set; }

        #endregion
    }
}