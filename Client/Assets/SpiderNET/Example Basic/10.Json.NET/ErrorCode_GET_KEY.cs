﻿using System.Collections;

namespace Example.JsonNET
{
    public class ErrorCode_GET_KEY : ErrorCode<ErrorCode_GET_KEY>
    {
        [Comment("업데이트가 필요합니다")]
        public const int NeedUpdate = 1;
        [Comment("접속할 수 없는 버전입니다")]
        public const int CannotConnect = 2;
    }
}