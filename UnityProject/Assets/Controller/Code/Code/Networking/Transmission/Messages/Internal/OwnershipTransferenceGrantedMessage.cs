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
    public class OwnershipTransferenceGrantedMessage : TransmissionMessage
    {
        //Public Variables(truncated to reduce packet size):
        /// <summary>
        /// instanceGUID
        /// </summary>
        public string ig;

        //Constructors:
        public OwnershipTransferenceGrantedMessage(string instanceGuid, string requestor) : base(TransmissionMessageType.OwnershipTransferenceGrantedMessage, TransmissionAudience.SinglePeer, requestor, true)
        {
            ig = instanceGuid;
        }
    }
}