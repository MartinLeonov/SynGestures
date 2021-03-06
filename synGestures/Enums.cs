﻿namespace synGestures
{
    public enum MouseKeyCode { Left, Middle, Right }
    public enum ActionType
    {
        MouseTapOne,
        MouseTapOneLong,
        MouseTapTwo,
        MouseTapTwoLong,
        MouseTapThree,
        MouseTapThreeLong,
        SwipeTwoLeft,
        SwipeTwoRight,
        SwipeThreeUp,
        SwipeThreeRight,
        SwipeThreeDown,
        SwipeThreeLeft,
        SwipeBorderTop,
        SwipeBorderRight,
        SwipeBorderBottom,
        SwipeBorderLeft
    }
    public enum ScrollDirection { None, Up, Down, Left, Right }
    public enum DefaultAction
    {
        NoAction,
        LeftClick,
        MiddleClick,
        RightClick,
        ShowMetroApps,
        ShowMetroAppSettings,
        ShowProgramList,
        ShowCharms,
        ShowMetroSearchApps,
        ShowMetroSearchSettings,
        ShowMetroSearchFiles,
        ShowMetroSettingsSidebar,
        ShowMetroSharingSidebar,
        ShowMetroDevicesSidebar,
        SnapMetroAppToRight,
        SnapMetroAppToLeft,
        SnapWindowToRight,
        SnapWindowToLeft,
        MaximizeWindow,
        MinimizeWindow,
        LockWindows,
        OpenExplorer,
        OpenRun,
        StartMenu,
        CloseWindow,
        GoToDesktop,
        ScrollToTop,
        ScrollToBottom,
        Left,
        Right,
        NextTab,
        PrevTab,
        ExplorerNewFolder,
        ExplorerFolderLevelUp,
        ExplorerTogglePreviewPane,
        ExplorerToggleDetailPane,
        ExplorerToggleRibbon,
        PageUp,
        PageDown,
        SwitchToLastWindow,
        SwitchToLastMetroWindow,
        WindowsScreenshot
    }
}
