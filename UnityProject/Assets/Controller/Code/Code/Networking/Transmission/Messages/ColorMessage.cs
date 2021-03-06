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
    public class ColorMessage : TransmissionMessage
    {
        //Public Variables(truncated to reduce packet size):
        /// <summary>
        /// value
        /// </summary>
        public Color v;

        //Constructors:
        public ColorMessage(Color value, string data = "", TransmissionAudience audience = TransmissionAudience.KnownPeers, string targetAddress = "") : base(TransmissionMessageType.ColorMessage, audience, targetAddress, true, data)
        {
            v = value;
        }
    }
}