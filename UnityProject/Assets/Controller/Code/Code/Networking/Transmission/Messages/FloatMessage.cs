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

namespace MagicLeapTools
{
    public class FloatMessage : TransmissionMessage
    {
        //Public Variables(truncated to reduce packet size):
        /// <summary>
        /// value
        /// </summary>
        public float v;

        //Constructors:
        public FloatMessage(float value, string data = "", TransmissionAudience audience = TransmissionAudience.KnownPeers, string targetAddress = "") : base(TransmissionMessageType.FloatMessage, audience, targetAddress, true, data)
        {
            v = value;
        }
    }
}