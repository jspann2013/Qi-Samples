// <copyright file="SdsTypeCode.cs" company="OSIsoft, LLC">
//
// Copyright (C) 2018 OSIsoft, LLC. All rights reserved.
//
// THIS SOFTWARE CONTAINS CONFIDENTIAL INFORMATION AND TRADE SECRETS OF
// OSIsoft, LLC.  USE, DISCLOSURE, OR REPRODUCTION IS PROHIBITED WITHOUT
// THE PRIOR EXPRESS WRITTEN PERMISSION OF OSIsoft, LLC.
//
// RESTRICTED RIGHTS LEGEND
// Use, duplication, or disclosure by the Government is subject to restrictions
// as set forth in subparagraph (c)(1)(ii) of the Rights in Technical Data and
// Computer Software clause at DFARS 252.227.7013
//
// OSIsoft, LLC
// 1600 Alvarado St, San Leandro, CA 94577
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace SdsRestApiCore
{
    public enum SdsTypeCode
    {
        Empty = 0,
        Object = 1,
        DbNull = 2,
        Boolean = 3,
        Char = 4,
        SByte = 5,
        Byte = 6,
        Int16 = 7,
        UInt16 = 8,
        Int32 = 9,
        UInt32 = 10,
        Int64 = 11,
        UInt64 = 12,
        Single = 13,
        Double = 14,
        Decimal = 15,
        DateTime = 16,
        String = 18,
        Guid = 19,
        DateTimeOffset = 20,
        TimeSpan = 21,
        Version = 22,

        NullableBoolean = 103,
        NullableChar = 104,
        NullableSByte = 105,
        NullableByte = 106,
        NullableInt16 = 107,
        NullableUInt16 = 108,
        NullableInt32 = 109,
        NullableUInt32 = 110,
        NullableInt64 = 111,
        NullableUInt64 = 112,
        NullableSingle = 113,
        NullableDouble = 114,
        NullableDecimal = 115,
        NullableDateTime = 116,
        NullableGuid = 119,
        NullableDateTimeOffset = 120,
        NullableTimeSpan = 121,

        BooleanArray = 203,
        CharArray = 204,
        SByteArray = 205,
        ByteArray = 206,
        Int16Array = 207,
        UInt16Array = 208,
        Int32Array = 209,
        UInt32Array = 210,
        Int64Array = 211,
        UInt64Array = 212,
        SingleArray = 213,
        DoubleArray = 214,
        DecimalArray = 215,
        DateTimeArray = 216,
        StringArray = 218,
        GuidArray = 219,
        DateTimeOffsetArray = 220,
        TimeSpanArray = 221,
        VersionArray = 222,

        Array = 400,
        IList = 401,
        IDictionary = 402,
        IEnumerable = 403,

        SdsType = 501,
        SdsTypeProperty = 502,
        SdsView = 503,
        SdsViewProperty = 504,
        SdsViewMap = 505,
        SdsViewMapProperty = 506,
        SdsStream = 507,
        SdsStreamIndex = 508,
        SdsTable = 509,
        SdsColumn = 510,
        SdsValues = 511,
        SdsObject = 512,

        SByteEnum = 605,
        ByteEnum = 606,
        Int16Enum = 607,
        UInt16Enum = 608,
        Int32Enum = 609,
        UInt32Enum = 610,
        Int64Enum = 611,
        UInt64Enum = 612,

        NullableSByteEnum = 705,
        NullableByteEnum = 706,
        NullableInt16Enum = 707,
        NullableUInt16Enum = 708,
        NullableInt32Enum = 709,
        NullableUInt32Enum = 710,
        NullableInt64Enum = 711,
        NullableUInt64Enum = 712,
    }
}
