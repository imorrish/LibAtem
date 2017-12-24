namespace LibAtem.Common
{
    // TODO - some of these don't look like possible macro operations
    public enum MacroOperationType
    {
        LoopMacro,

        ProgramInput = 0x0002,
        PreviewInput = 0x0003,

        CutTransition = 0x0004,
        AutoTransition = 0x0005,

        MacroUserWait,//
        MacroSleep = 0x0007,

        RunMacro,
        UserResumeMacro,
        StartRecordMacro,
        StopRecordMacro,

        VideoMode = 0x000c,

        CameraControlVoidBool,
        CameraControlByte,
        CameraControl16Bit,
        CameraControl32Bit,
        CameraControl64Bit,
        CameraControlFixedPoint16Bit,

        StopMacro,

        TransitionWipeSymmetry = 0x0014,
        TransitionWipeXPosition = 0x0015,
        TransitionWipeYPosition = 0x0016,
        TransitionWipeSymmetryOffset,
        TransitionWipeXPositionOffset,
        TransitionWipeYPositionOffset,

        DownConvertMode = 0x001a,
        InputVideoPort = 0x001b,
        ColorGeneratorHue = 0x001c,
        ColorGeneratorSaturation = 0x001d,
        ColorGeneratorLuminescence = 0x001e,

        AuxiliaryInput = 0x001f,

        MultiViewWindowInput = 0x0020,
        MultiViewLayout = 0x0021,

        DeleteMacro,

        MacroLabel,
        MacroNote,

        KeyCutInput = 0x0025,
        KeyFillInput = 0x0026,
        KeyOnAir = 0x0027,
        KeyType = 0x0028,

        LumaKeyClip = 0x0029,
        LumaKeyGain = 0x002a,
        
        KeyFlyEnable,

        LumaKeyInvert = 0x002c,
        LumaKeyPreMultiply = 0x002d,

        PatternKeyInvert,

        KeyMaskEnable = 0x002f,
        KeyMaskTop = 0x0030,
        KeyMaskBottom = 0x0031,
        KeyMaskLeft = 0x0032,
        KeyMaskRight = 0x0033,
          
        TransitionDVEPattern = 0x0034,
        DVEKeyMaskEnable = 0x0035,
        DVEKeyMaskTop = 0x0036,
        DVEKeyMaskBottom = 0x0037,
        DVEKeyMaskLeft = 0x0038,
        DVEKeyMaskRight = 0x0039,
        TransitionDVERate = 0x003a,

        ChromaKeyClip = 0x003b,
        ChromaKeyGain = 0x003c,
        ChromaKeyHue = 0x003d,
        ChromaKeyLift = 0x003e,
        ChromaKeyNarrow = 0x003f,

        PatternKeyPattern = 0x0040,
        PatternKeySize = 0x0041,
        PatternKeySoftness = 0x0042,
        PatternKeyXPosition = 0x0043,
        PatternKeyYPosition = 0x0044,
        PatternKeySymmetry = 0x0045,

        DVEAndFlyKeyRate = 0x0046,
        DVEAndFlyKeyXSize = 0x0047,
        DVEAndFlyKeyYSize = 0x0048,
        // 0x0049
        DVEAndFlyKeyXPosition = 0x004a,
        DVEAndFlyKeyYPosition = 0x004b,
        // 0x004c
        DVEKeyShadowEnable = 0x004d,
        DVEKeyBorderEnable = 0x004e,
        DVEAndFlyKeyRotation = 0x004f,

        FlyKeySetKeyFrame = 0x0050,
        FlyKeyResetKeyFrame,
        FlyKeyRunToFull = 0x0052,
        FlyKeyRunToFullWithRate,
        FlyKeyRunToKeyFrame = 0x0054,
        FlyKeyRunToKeyFrameWithRate,
        FlyKeyRunToInfinity = 0x0056,

        DVEKeyShadowDirection = 0x0058,
        DVEKeyShadowAltitude = 0x0059,

        DVEKeyBorderHue = 0x005a,
        DVEKeyBorderSaturation = 0x005b,
        DVEKeyBorderLuminescence = 0x005c,
        DVEKeyBorderBevel = 0x005d,
        DVEKeyBorderOuterWidth = 0x005e,
        DVEKeyBorderInnerWidth = 0x005f,
        DVEKeyBorderOuterSoftness = 0x0060,
        DVEKeyBorderInnerSoftness = 0x0061,
        DVEKeyBorderOpacity = 0x0062,
        DVEKeyBorderBevelPosition = 0x0063,
        DVEKeyBorderBevelSoftness = 0x0064,

        FlyKeyFrameXSize,
        FlyKeyFrameYSize,
        FlyKeyFrameXPosition,
        FlyKeyFrameYPosition,
        FlyKeyFrameRotation,
        FlyKeyFrameShadowDirection,
        FlyKeyFrameShadowAltitude,
        FlyKeyFrameBorderHue,
        FlyKeyFrameBorderSaturation,
        FlyKeyFrameBorderLuminescence,
        FlyKeyFrameBorderOuterWidth,
        FlyKeyFrameBorderInnerWidth,
        FlyKeyFrameBorderOuterSoftness,
        FlyKeyFrameBorderInnerSoftness,
        FlyKeyFrameBorderOpacity,
        FlyKeyFrameBorderBevelPosition,
        FlyKeyFrameBorderBevelSoftness,
        FlyKeyFrameMaskTop,
        FlyKeyFrameMaskBottom,
        FlyKeyFrameMaskLeft,
        FlyKeyFrameMaskRight,

        TransitionWipeRate = 0x007c,
        TransitionWipePattern = 0x007d,
        TransitionWipeBorderWidth = 0x007e,
        TransitionWipeBorderSoftness = 0x007f,
        TransitionWipeBorderFillInput = 0x0080,
        TransitionWipeAndDVEReverse = 0x0081,
        TransitionWipeAndDVEFlipFlop = 0x0082,

        TransitionStyle = 0x0083,
        TransitionSource = 0x0084,
        TransitionPosition = 0x0085,
        TransitionPreview = 0x0086,
        TransitionMixRate = 0x0087,
        TransitionDipRate = 0x0088,
        TransitionDipInput = 0x0089,
        TransitionStingerRate = 0x008a,
        TransitionStingerSourceNone,
        TransitionStingerSourceMediaPlayer = 0x008c,
        TransitionStingerClipDuration = 0x008d,
        TransitionStingerTriggerPoint = 0x008e,
        TransitionStingerMixRate = 0x008f,
        TransitionStingerPreRoll = 0x0090,
        TransitionStingerResetDurations = 0x0091,
        TransitionStingerDVEClip = 0x0092,
        TransitionStingerDVEGain = 0x0093,
        TransitionStingerDVEInvert = 0x0094,
        TransitionStingerDVEPreMultiply = 0x0095,

        DownstreamKeyFillInput = 0x0096,
        DownstreamKeyCutInput = 0x0097,
        DownstreamKeyRate = 0x0098,
        DownstreamKeyAuto = 0x0099,
        DownstreamKeyOnAir = 0x009a,
        DownstreamKeyTie = 0x009b,
        DownstreamKeyClip = 0x009c,
        DownstreamKeyGain = 0x009d,
        DownstreamKeyMaskEnable = 0x009e,
        DownstreamKeyMaskTop = 0x009f,
        DownstreamKeyMaskBottom = 0x00a0,
        DownstreamKeyMaskLeft = 0x00a1,
        DownstreamKeyMaskRight = 0x00a2,
        DownstreamKeyInvert = 0x00a3,
        DownstreamKeyPreMultiply = 0x00a4,

        FadeToBlackRate = 0x00a5,
        FadeToBlackCut, // Not used
        FadeToBlackAuto = 0x00a7,

        SuperSourceArtCutInput = 0x00a8,
        SuperSourceArtFillInput = 0x00a9,
        SuperSourceArtAbove = 0x00aa,
        SuperSourceArtPreMultiply,
        SuperSourceArtClip,
        SuperSourceArtGain,
        SuperSourceArtInvert,
        SuperSourceBorderEnable,
        SuperSourceBorderHue,
        SuperSourceBorderSaturation,
        SuperSourceBorderLuminescence,
        SuperSourceBorderBevel,
        SuperSourceBorderOuterWidth,
        SuperSourceBorderInnerWidth,
        SuperSourceBorderOuterSoftness,
        SuperSourceBorderInnerSoftness,
        SuperSourceBorderBevelPosition,
        SuperSourceBorderBevelSoftness,
        SuperSourceShadowDirection,
        SuperSourceShadowAltitude,
        SuperSourceBoxEnable = 0x00bc,
        SuperSourceBoxInput = 0x00bd,
        SuperSourceBoxXPosition = 0x00be,
        SuperSourceBoxYPosition = 0x00bf,
        SuperSourceBoxSize = 0x00c0,
        SuperSourceBoxMaskEnable = 0x00c1,
        SuperSourceBoxMaskTop = 0x00c2,
        SuperSourceBoxMaskBottom = 0x00c3,
        SuperSourceBoxMaskLeft = 0x00c4,
        SuperSourceBoxMaskRight = 0x00c5,
        
        AudioMixerInputMixType = 0x00c6,
        AudioMixerInputGain = 0x00c7,
        AudioMixerInputBalance = 0x00c8,
        AudioMixerMasterOutGain = 0x00c9,
        AudioMixerMasterOutBalance, // ?
        AudioMixerMasterOutFollowFadeToBlackMixEffectBlock1 = 0x00cb,
        AudioMixerMonitorOut = 0x00cc,
        AudioMixerMonitorOutGain = 0x00cd,
        AudioMixerMonitorOutMute = 0x00ce,
        AudioMixerMonitorOutSolo = 0x00cf,
        AudioMixerMonitorOutSoloInput = 0x00d0,
        AudioMixerMonitorOutDim = 0x00d1,
        AudioMixerMonitorOutDimLevel,
        AudioMixerInputResetPeaks = 0x00d3,
        AudioMixerInputResetAllPeaks,
        AudioMixerMasterOutResetPeaks = 0x00d5,
        AudioMixerMonitorOutResetPeaks,

        TransitionDVEFillInput,
        TransitionDVECutInput,
        TransitionDVECutInputEnable,

        MediaPlayerSourceStillIndex = 0x00da,
        MediaPlayerSourceClipIndex, //
        MediaPlayerGoToBeginning, //
        MediaPlayerGoToFrame,
        MediaPlayerPlay = 0x00de,
        MediaPlayerPause,
        MediaPlayerLoop = 0x00e0,
        MediaPlayerSourceStill = 0x00e1,
        MediaPlayerSourceClip, // --

        PatternKeySizeOffset,
        PatternKeyXPositionOffset,
        PatternKeyYPositionOffset,

        DVEAndFlyKeyXSizeOffset,
        DVEAndFlyKeyYSizeOffset,
        DVEAndFlyKeyXPositionOffset,
        DVEAndFlyKeyYPositionOffset,

        SuperSourceBoxXPositionOffset,
        SuperSourceBoxYPositionOffset,
        SuperSourceBoxSizeOffset,

        MediaPlayerPlayFromBeginning,

        PtzRs422ViscaSetPanVelocity,
        PtzRs422ViscaSetTiltVelocity,
        PtzRs422ViscaSetZoomVelocity,
        PtzRs422ViscaUpdatePanTiltPosition,
        PtzRs422ViscaUpdateZoomPosition,
        PtzRs422ViscaGotoPanTiltPosition,
        PtzRs422ViscaGotoZoomPosition,
        PtzRs422ViscaAllocateAddresses,
        PtzRs422ViscaBaudRate,

        SetSerialPortFunction = 0x0103,

        GvgReadCrosspointPrgmBkgd,
        GvgReadCrosspointPresetBkgd,
        GvgReadCrosspointKey,
        GvgReadWipePattern,
        GvgReadTransitionMode,
        GvgReadTransitionRateAutoTrans,
        GvgReadTransitionRateDskMix,
        GvgReadTransitionRateFadeToBlack,
        GvgReadLampStatusMap,
        GvgReadAnalogControl,
        GvgReadPushButtonLampControl,
        GvgReadFieldMode,
        GvgReadSoftwareVersion,
        
        ToggleTransitionWipeAndDVEReverse,

        ToggleKeyMaskEnable,
        ToggleKeyOnAir,
        ToggleLumaKeyInvert,
        ToggleDVEKeyBorderEnable,
        ToggleDVEKeyShadowEnable,
        ToggleDownstreamKeyOnAir,
        ToggleDownstreamKeyTie,
        ToggleDownstreamKeyInvert,
        ToggleDownstreamKeyMaskEnable,
        ToggleTransitionSource,

        AudioMixerTalkbackMuteSDI,

        HyperDeckSetIPv4Address,
        HyperDeckSetSourceClipIndex, //
        HyperDeckGoToPositionDelta,
        HyperDeckUpdatePosition,
        HyperDeckGoToPosition,
        HyperDeckSetLoop, //
        HyperDeckSetSpeed, //
        HyperDeckPlay, //
        HyperDeckStop, //
        HyperDeckRecord,
        HyperDeckSetInput,
        HyperDeckSetSingleClip, //
        HyperDeckSetSourceSlotIndex,
        HyperDeckSetRollOnTake,
        HyperDeckSetRollOnTakeFrameDelay,

        MultiViewVuMeterEnable,
        MultiViewVuMeterOpacity,
        MultiViewSafeAreaEnable,
        MultiViewPgmPvwSwap,

        AudioMixerHeadphoneOutGain,
        AudioMixerHeadphoneOutMasterGain,
        AudioMixerHeadphoneOutTalkbackGain,
        AudioMixerHeadphoneOutSidetoneGain,
        AudioMixerInputTalkbackMuteSDI,

        MixMinusSetAudioMode,
        AudioMixerAfvFollowTransition = 0x012b,
    }
}