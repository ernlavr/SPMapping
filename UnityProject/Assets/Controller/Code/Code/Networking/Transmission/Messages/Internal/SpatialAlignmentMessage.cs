// %BANNER_BEGIN%
// ---------------------------------------------------------------------
// %COPYRIGHT_BEGIN%
//
// Copyright (c) 2019-present, Magic Leap, Inc. All Rights Reserved.
// Use of this file is governed by the Developer Agreement, located
// here: https://auth.magicleap.com/terms/developer
//
// %COPYRIGHT_END%
// ---------------------------------------------------------------------
// %BANNER_END%

using UnityEngine;

namespace MagicLeapTools
{
    public class SpatialAlignmentMessage : TransmissionMessage
    {
        //Constructors:
        public SpatialAlignmentMessage(string targetAddress) : base(TransmissionMessageType.SpatialAlignmentMessage, TransmissionAudience.SinglePeer, targetAddress, true)
        {
        }
    }
}